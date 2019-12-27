using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuzzleQuest
{
    public partial class Logowanie : Form
    {
        public string login;
        public static string postać; 
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //wyjdz z okna logowania do Menu Glownego
            this.Hide();
            PuzzleQuest ss = new PuzzleQuest();
            ss.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //zaloguj postać do gry
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\48506\Desktop\Git_projekt\PuzzleQuest\PuzzleQuest\PuzzleQuest\Resources\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Tabela where Login='" + textBox_login.Text + "' and Haslo ='" + textBox_haslo.Text + "'", con);
            SqlDataAdapter postac = new SqlDataAdapter("Select Postac From Tabela where Login='" + textBox_login.Text + "'", con);
            DataTable data_table = new DataTable();
            DataTable postac_table = new DataTable();
            sda.Fill(data_table);
            postac.Fill(postac_table);
            postać = postac_table.Rows[0][0].ToString();

            if (data_table.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Mapa pp = new Mapa();

                //wyswietlenie nazwy zalogowanego gracza na mapie
                login = textBox_login.Text;
                pp.label_pokaz_login.Text = login;

                //pobranie z bazy wspolrzednej x
                SqlDataAdapter wsprz_X = new SqlDataAdapter("Select wspolrzedna_X From Tabela where Login='" + textBox_login.Text + "'", con);
                DataTable wsprz_X_table = new DataTable();
                wsprz_X.Fill(wsprz_X_table);
                
                //pobranie z bazy wspolrzednej y
                SqlDataAdapter wsprz_Y = new SqlDataAdapter("Select wspolrzedna_Y From Tabela where Login='" + textBox_login.Text + "'", con);
                DataTable wsprz_Y_table = new DataTable();
                wsprz_Y.Fill(wsprz_Y_table);


                int coordinate_X = Int32.Parse(wsprz_X_table.Rows[0][0].ToString());
                //MessageBox.Show("wspolrzedna Ccoordinate X to: " + coordinate_X);
                int coordinate_Y = Int32.Parse(wsprz_Y_table.Rows[0][0].ToString());
                //MessageBox.Show("wspolrzedna coordinate Y to: " + coordinate_Y);

                Mapa.x = coordinate_X;
                Mapa.y = coordinate_Y;
                Mapa.rycerz.Location = new Point(Mapa.x * 70, Mapa.y * 70);
                pp.Show();
                
            }
            else
            {
                MessageBox.Show("Sprawdź ponownie Login oraz hasło", "Niepoprawne logowanie");
            }

        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
    }
}
