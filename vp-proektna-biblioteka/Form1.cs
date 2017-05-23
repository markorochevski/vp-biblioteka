using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;

namespace vp_proektna_biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        public void fill()
        {
            DataRow anyRow = booksDataSet.Books.NewRow();
            anyRow[0] = 15;
            anyRow[1] = "Naslov";
            anyRow[2] = "Avtor";
            anyRow[3] = "zanr";
            booksDataSet.Books.Rows.Add(anyRow);
        }

        public void Ispolni()
        {
           // string conn = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            String query = "SELECT * FROM [Books] ORDER BY Title";
            SqlConnection konekcija = new SqlConnection();
            //string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
        AppDomain.CurrentDomain.SetData("DataDirectory", path);
            konekcija.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    string item = reader["Title"].ToString();
                    lbKnigi.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
            Ispolni();
        }

        private void btnPrebaraj_Click(object sender, EventArgs e)
        {
            lbKnigi.Items.Clear();
            String query = "SELECT Title FROM [Books] WHERE Title='"+tbPrebaraj.Text + "' OR Category='" + tbPrebaraj.Text + "' OR Author='" + tbPrebaraj.Text + "' ORDER BY Title";
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string item = reader["Title"].ToString();
                    lbKnigi.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnDodadiKniga_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
        }
    }
}
