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
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Luk\Desktop\Puzzle Quest\v6\PuzzleQuest\PuzzleQuest\Resources\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Tabela where Login='" + textBox_login.Text + "' and Haslo ='" + textBox_haslo.Text + "'", con);
            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            if (data_table.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Mapa pp = new Mapa();

                //wyswietlenie nazwy zalogowanego gracza na mapie
                login = textBox_login.Text;
                pp.label_pokaz_login.Text = login;

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
