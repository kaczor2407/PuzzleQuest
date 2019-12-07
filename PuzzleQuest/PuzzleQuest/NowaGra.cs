using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleQuest
{

    public partial class Nowa_Gra : Form
    {
        const int sizeCard = 70;
        const int rozmiar = 8;
        int zywotność;
        int zywotność_Postaci;
        int usuniecie = 0;
        int licznik_sprawdzen = 0;
        static int z = 0;
        private int timer;
        int obrazenia_trzy_klocki = 30;
        int obrazenia_cztery_klocki = 40;
        int obrazenia_piec_klocków = 50;
        int suma_niebieskich = 0;
        int suma_zielonych = 0;
        int suma_czerwonych = 0;
        int suma_zoltych = 0;
        int suma_monety = 0;
        int suma_doswiadczenie = 0;
        int suma_atak = 0;
        int obrazenia_potwora;
        int crytyczne_potwora;
        

        Random losowanie_obrazkow = new Random();
        Random losowanie_obrazen = new Random();
        Button[,] karty = new Button[rozmiar, rozmiar];
        Button pierwszy;
        Image zamiana;
        List<Image> nazwa_obrazkow = new List<Image>();


        string[] przeciwnik = new string[7];
        object[] tab_przeciwnikow = new object[7];
        Belial belial = new Belial("Belial", 1000, 100f, 0.6f);
        Radament radament = new Radament("Radament", 2500, 100f, 0.6f);


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            Text = timer.ToString();

        }


        public Nowa_Gra()
        {

            InitializeComponent();

            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.klocek_niebieski);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.klocek_zielony);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.klocek_zolty);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.atak);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.klocek_czerwony);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.doswiadczenie);
            nazwa_obrazkow.Add(global::PuzzleQuest.Properties.Resources.monety);


            tab_przeciwnikow[0] = belial;
            tab_przeciwnikow[1] = radament;


            przeciwnik[0] = belial.nazwa;
            przeciwnik[1] = radament.nazwa;

            int los;
            
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Button b = new Button();
                    b.Location = new Point(x * 70, y * 70);
                    b.Size = new Size(sizeCard, sizeCard);
                    los = losowanie_obrazkow.Next(0, 6);
                    b.Image = nazwa_obrazkow[los];
                    b.Tag = new Point(x, y);
                    b.MouseClick += B_MouseClick;
                    panel1.Location = new Point(400, 0);
                    panel1.Size = new Size(700, 700);
                    panel1.Controls.Add(b);
                    karty[x, y] = b;
                }
            }

            //label1.BackColor = progressBar1.BackColor;
            //label1.ForeColor = Color.Black;
            //zywotność = progressBar1.Value;

            ustawienie_Zywotnosci();
            ustawienie_hp_Postaci();
            sprawdzenie_Klockow();

            ustawienie_Zycia();

            



        }



        private void ustawienie_Zywotnosci()
        {
            if (tab_przeciwnikow[z] == belial)
            {
                zywotność = belial.hp;
            }
            else if (tab_przeciwnikow[z] == radament)
            {
                zywotność = radament.hp;
            }
        }
        private void ustawienie_Zycia()
        {
            if (tab_przeciwnikow[z] == belial)
            {
                progressBar1.Value = belial.hp;
                progressBar1.Maximum = belial.hp;
                label1.Text = progressBar1.Value.ToString() + "/" + zywotność;


            }
            else if (tab_przeciwnikow[z] == radament)
            {
                progressBar1.Value = radament.hp;
                progressBar1.Maximum = radament.hp;
                label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

            }
        }

        private void ustawienie_hp_Postaci()
        {
            zywotność_Postaci = pasek_zycia_Postaci.Value;
            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
        }

        private void leczenie_Postaci()
        {
            if (suma_czerwonych >= 10)
            {
                Ulecz.Enabled = true;
            }
        }

        private void sprawdzenie_Klockow()
        {


            int los = 0;
            int szansa_na_pieniadze;
            Random losowanie_obrazkow = new Random();




            for (int i = 0; i < 8; i++) // sprawdzanie w pionie
                for (int j = 0; j <= 5; j++)
                {
                    if (karty[i, j].Image == karty[i, j + 1].Image && karty[i, j + 1].Image == karty[i, j + 2].Image)
                    {

                        if (j <= 3 && karty[i, j].Image == karty[i, j + 3].Image && karty[i, j].Image == karty[i, j + 4].Image)
                        {

                            if (progressBar1.Value >= obrazenia_piec_klocków)
                            {

                                if (usuniecie > 0)
                                {

                                    progressBar1.Value = progressBar1.Value - obrazenia_piec_klocków;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_piec_klocków.ToString() + " Obrazeń ";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;
                                    if(karty[i,j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 5;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 5;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 5;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 5;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 5;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 5;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 50;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }

                                }



                            }
                            else
                            {
                                progressBar1.Value = 0;

                            }
                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);
                            if (licznik_sprawdzen >= 2)
                            {
                                
                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                    
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń \n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                                zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            }
                            for (int x = i; x <= i; x++)
                            {
                                for (int y = j; y <= j + 4; y++)
                                {
                                    //karty[x, y].Size = new Size(10, 10);
                                    y += 4;

                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 4)
                                        {
                                            karty[x, w].Image = karty[x, w - 5].Image;
                                        }
                                        else if ((w == 0 || w == 1 || w == 2 || w == 3 || w == 4))
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }
                        }
                        else if (j <= 4 && karty[i, j].Image == karty[i, j + 3].Image)
                        {
                            if (progressBar1.Value >= obrazenia_cztery_klocki)
                            {
                                if (usuniecie > 0)
                                {
                                    progressBar1.Value = progressBar1.Value - obrazenia_cztery_klocki;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_cztery_klocki.ToString() + " Obrazeń \n";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

                                    if (karty[i, j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 4;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 4;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 4;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 4;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 4;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 4;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 30;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }
                                }


                            }
                            else
                            {
                                progressBar1.Value = 0;


                            }
                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);
                            if (licznik_sprawdzen >= 2)
                            {
                                
                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                            }
                            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            for (int x = i; x <= i; x++)
                            {
                                for (int y = j; y <= j + 3; y++)
                                {
                                    y += 3;
                                    //karty[x, y].Size = new Size(10, 10);
                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 3)
                                        {
                                            karty[x, w].Image = karty[x, w - 4].Image;
                                        }
                                        else if ((w == 0 || w == 1 || w == 2 || w == 3))
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }
                        }
                        else if (j <= 5 && karty[i, j].Image == karty[i, j + 2].Image)
                        {
                            
                            if (progressBar1.Value >= obrazenia_trzy_klocki)
                            {
                                if (usuniecie > 0)
                                {
                                    progressBar1.Value = progressBar1.Value - obrazenia_trzy_klocki;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_trzy_klocki.ToString() + " Obrazeń \n";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

                                    if (karty[i, j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 3;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 3;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 3;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 3;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 3;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 3;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 30;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                progressBar1.Value = 0;
                            }

                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);
                            if (licznik_sprawdzen >= 2)
                            {
                                
                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";

                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń!\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                            }
                            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            for (int x = i; x <= i; x++)
                            {
                                for (int y = j; y <= j + 2; y++)
                                {
                                    y += 2;
                                    //karty[x, y].Size = new Size(10, 10);
                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 2)
                                        {
                                            karty[x, w].Image = karty[x, w - 3].Image;
                                        }
                                        else if ((w == 0 || w == 1 || w == 2))
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }
                        }
                    }

                }
            for (int i = 0; i <= 5; i++) // sprawdzanie w poziomie
                for (int j = 0; j < 8; j++)
                {

                    if (karty[i, j].Image == karty[i + 1, j].Image && karty[i + 1, j].Image == karty[i + 2, j].Image)
                    {

                        if (i <= 3 && karty[i, j].Image == karty[i + 4, j].Image && karty[i, j].Image == karty[i + 3, j].Image)
                        {
                            if (progressBar1.Value >= obrazenia_piec_klocków)
                            {
                                if (usuniecie > 0)
                                {

                                    progressBar1.Value = progressBar1.Value - obrazenia_piec_klocków;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_piec_klocków.ToString() + " Obrazeń \n";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

                                    if (karty[i, j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 5;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 5;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 5;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 5;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 5;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 5;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 50;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                progressBar1.Value = 0;

                            }
                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);

                            if (licznik_sprawdzen >= 2)
                            {
                                
                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";

                                    if (pasek_zycia_Postaci.Value >=  obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń!\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                            }
                            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            for (int x = i; x <= i + 4; x++)
                            {
                                for (int y = j; y <= j; y++)
                                {
                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 0)
                                            karty[x, w].Image = karty[x, w - 1].Image;
                                        else if (w == 0)
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }
                        }
                        else if (i <= 4 && karty[i, j].Image == karty[i + 3, j].Image)
                        {
                            if (progressBar1.Value >= obrazenia_cztery_klocki)
                            {

                                if (usuniecie > 0)
                                {
                                    progressBar1.Value = progressBar1.Value - obrazenia_cztery_klocki;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_cztery_klocki.ToString() + " Obrazeń \n";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

                                    if (karty[i, j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 4;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 4;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 4;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 4;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 4;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 4;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 40;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                progressBar1.Value = 0;
                            }
                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);
                            if (licznik_sprawdzen >= 2)
                            {
                                
                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";

                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń!\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                            }
                            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            for (int x = i; x <= i + 3; x++)
                            {
                                for (int y = j; y <= j; y++)
                                {
                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 0)
                                            karty[x, w].Image = karty[x, w - 1].Image;
                                        else if (w == 0)
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }
                        }

                        else if (i <= 5 && karty[i, j].Image == karty[i + 2, j].Image)
                        {


                            if (progressBar1.Value >= obrazenia_trzy_klocki)
                            {
                                if (usuniecie >= 0)
                                {
                                    progressBar1.Value = progressBar1.Value - obrazenia_trzy_klocki;
                                    textBox1.Text = textBox1.Text + "\r\nZadales " + obrazenia_trzy_klocki.ToString() + " Obrazeń \n";
                                    label1.Text = progressBar1.Value.ToString() + "/" + zywotność;

                                    if (karty[i, j].Image == nazwa_obrazkow[0])
                                    {
                                        suma_niebieskich += 3;
                                        ilosc_niebieskich.Text = suma_niebieskich.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[1])
                                    {
                                        suma_zielonych += 3;
                                        ilosc_zielonych.Text = suma_zielonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[2])
                                    {
                                        suma_zoltych += 3;
                                        ilosc_zoltych.Text = suma_zoltych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[3])
                                    {
                                        suma_atak += 3;
                                        atak_label.Text = suma_atak.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[4])
                                    {
                                        suma_czerwonych += 3;
                                        ilosc_czerwonych.Text = suma_czerwonych.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[5])
                                    {
                                        suma_doswiadczenie += 3;
                                        doswiadczenie_label.Text = suma_doswiadczenie.ToString();
                                    }
                                    else if (karty[i, j].Image == nazwa_obrazkow[6])
                                    {
                                        szansa_na_pieniadze = losowanie_obrazkow.Next(1, 10);
                                        if (szansa_na_pieniadze <= 5)
                                        {
                                            suma_monety += 30;
                                            monety.Text = suma_monety.ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                progressBar1.Value = 0;
                            }
                            crytyczne_potwora = losowanie_obrazkow.Next(1, 10);
                            obrazenia_potwora = losowanie_obrazen.Next(30, 70);
                            if (licznik_sprawdzen >= 2)
                            {
                                

                                if (crytyczne_potwora <= 2)
                                {
                                    obrazenia_potwora = obrazenia_potwora * 2;
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń krytycznych!\n";

                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                    {
                                        pasek_zycia_Postaci.Value = 0;
                                    }
                                }
                                else
                                {
                                    textBox1.Text = textBox1.Text + "\r\n" + przeciwnik[z] + " zadaje " + obrazenia_potwora + " Obrazeń\n";
                                    if (pasek_zycia_Postaci.Value >= obrazenia_potwora)
                                    {
                                        pasek_zycia_Postaci.Value = pasek_zycia_Postaci.Value - obrazenia_potwora;
                                    }
                                    else
                                        pasek_zycia_Postaci.Value = 0;
                                }
                            }
                            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
                            for (int x = i; x <= i + 2; x++)
                            {
                                for (int y = j; y <= j; y++)
                                {
                                    //karty[x, y].Size = new Size(10, 10);
                                    for (int w = y; w >= 0; w--)
                                    {
                                        if (w > 0)
                                            karty[x, w].Image = karty[x, w - 1].Image;
                                        else if (w == 0)
                                        {
                                            los = losowanie_obrazkow.Next(0, 7);
                                            karty[x, w].Image = nazwa_obrazkow[los];
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            licznik_sprawdzen++;

            leczenie_Postaci();

            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;


            if (progressBar1.Value == 0)
            { 
                if (z == 0)
                {
                    
                    MessageBox.Show("Pokonałeś przeciwnika " + przeciwnik[z]);
                }
                else if (z == 1)
                {
                    
                    MessageBox.Show("Pokonałeś przeciwnika " + przeciwnik[z]);
                }
                z++;

                wroc_do_Mapy();
            }
            else if(pasek_zycia_Postaci.Value == 0)
            {
                if (z == 0)
                {
                   
                    MessageBox.Show("Pokonał Cie " + przeciwnik[z]);
                    Mapa.x--;
                }
                else if (z == 1)
                {
                    
                    MessageBox.Show("Pokonał Cie " + przeciwnik[z]);
                    Mapa.y--;
                }

                
                wroc_do_Mapy();
            }

        }


        private void B_MouseClick(object sender, MouseEventArgs e)
        {

            //(sender as Button).Size = new Size(80, 80);
            //(sender as Button).Top -= 20;
            //(sender as Button).Left -= 20;
            
            sprawdzenie_Klockow();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    karty[i, j].FlatStyle = FlatStyle.Standard;
                    karty[i, j].FlatAppearance.BorderColor = Color.Empty;
                    karty[i, j].FlatAppearance.BorderSize = 3;

                }
            }

            
                

            if (pierwszy == null)
            {
                pierwszy = ((Button)sender);
                //MessageBox.Show(pierwszy.Location.X.ToString()+"   "+pierwszy.Location.Y.ToString());
                //MessageBox.Show(pierwszy.BackColor.ToString());
                //MessageBox.Show(pierwszy.FlatStyle.ToString());
                //MessageBox.Show(pierwszy.FlatAppearance.BorderColor.ToString());
                //MessageBox.Show(pierwszy.FlatAppearance.BorderSize.ToString());
                pierwszy.BackColor = System.Drawing.Color.Blue;
                pierwszy.FlatStyle = FlatStyle.Flat;
                pierwszy.FlatAppearance.BorderColor = Color.Red;
                pierwszy.FlatAppearance.BorderSize = 2;
            }
            else
            {
                Button drugi = ((Button)sender);
                if ((Math.Abs(((Point)(pierwszy.Tag)).X - ((Point)(drugi.Tag)).X) <= 1 &&
                     Math.Abs(((Point)(pierwszy.Tag)).Y - ((Point)(drugi.Tag)).Y) == 0)
                    || (Math.Abs(((Point)(pierwszy.Tag)).Y - ((Point)(drugi.Tag)).Y) <= 1 &&
                        Math.Abs(((Point)(pierwszy.Tag)).X - ((Point)(drugi.Tag)).X) == 0))
                {
                    zamiana = pierwszy.Image;
                    pierwszy.Image = drugi.Image;
                    drugi.Image = zamiana;

                    //MessageBox.Show("Zamiana");
                }
                else
                {
                    MessageBox.Show("Za daleko");
                }

                pierwszy.BackColor = System.Drawing.Color.Empty;
                pierwszy.FlatStyle = FlatStyle.Standard;
                pierwszy.FlatAppearance.BorderColor = Color.Empty;
                pierwszy.FlatAppearance.BorderSize = 2;
                pierwszy = null;
            }
            usuniecie++;

            for (int i = 0; i <= 5; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (karty[i, j].Image == karty[i + 1, j].Image && karty[i + 1, j].Image == karty[i + 2, j].Image)
                        {
                            if (i <= 5 && karty[i, j].Image == karty[i + 2, j].Image)
                            {
                                karty[i, j].FlatStyle = FlatStyle.Flat;
                                karty[i, j].FlatAppearance.BorderColor = Color.Blue;
                                karty[i, j].FlatAppearance.BorderSize = 3;
                                karty[i + 1, j].FlatStyle = FlatStyle.Flat;
                                karty[i + 1, j].FlatAppearance.BorderColor = Color.Blue;
                                karty[i + 1, j].FlatAppearance.BorderSize = 3;
                                karty[i + 2, j].FlatStyle = FlatStyle.Flat;
                                karty[i + 2, j].FlatAppearance.BorderColor = Color.Blue;
                                karty[i + 2, j].FlatAppearance.BorderSize = 3;

                            }
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        if (karty[i, j].Image == karty[i, j + 1].Image && karty[i, j + 1].Image == karty[i, j + 2].Image)
                        {
                            if (j <= 5 && karty[i, j].Image == karty[i, j + 2].Image)
                            {
                                karty[i, j].FlatStyle = FlatStyle.Flat;
                                karty[i, j].FlatAppearance.BorderColor = Color.Blue;
                                karty[i, j].FlatAppearance.BorderSize = 3;
                                karty[i, j + 1].FlatStyle = FlatStyle.Flat;
                                karty[i, j + 1].FlatAppearance.BorderColor = Color.Blue;
                                karty[i, j + 1].FlatAppearance.BorderSize = 3;
                                karty[i, j + 2].FlatStyle = FlatStyle.Flat;
                                karty[i, j + 2].FlatAppearance.BorderColor = Color.Blue;
                                karty[i, j + 2].FlatAppearance.BorderSize = 3;

                            }
                            
                        }
                    }

                }

           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void otworz()

        {

            Application.Run(new Mapa());

        }
        private void wroc_do_Mapy()
        {
            System.Threading.Thread map =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworz));
            //uruchomienie nowego wątku

            map.Start();

            //zamknięcie starego wątku

            Application.ExitThread();
        }

        private void Nowa_Gra_Load(object sender, EventArgs e)
        {

        }

        private void Ulecz_Click(object sender, EventArgs e)
        {
            pasek_zycia_Postaci.Value += 200;
            Ulecz.Enabled = false;
            suma_czerwonych = 0;
            ilosc_czerwonych.Text = suma_czerwonych.ToString();
            zycie_postaci_Label.Text = pasek_zycia_Postaci.Value.ToString() + "/" + zywotność_Postaci;
        }
    }
}