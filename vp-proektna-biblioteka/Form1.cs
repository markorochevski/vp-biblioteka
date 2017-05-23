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
            lbKnigi.Items.Clear();
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

            rbPrebaruvanje.Checked = true;
            
        }

        private void btnDodadiKniga_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Ispolni();
            }
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            DialogResult result = MessageBox.Show("Дали сакаш да ги изнајмиш овие книги?",
                    "Потврди нарачка",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //MessageBox.Show("Книгите се изнајмени!");
                //lbKosnicka.Items.Clear();
                InfoForm infoForm = new InfoForm();
                if (infoForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lbKosnicka.Items.Clear();
                }
            }
        }

        private void rbCelosna_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCelosna.Checked)
            {
                Ispolni();
            }
            else
            {
                btnPrebaraj_Click(sender, e);
            }
        }

        private void btnDodadiKosnicka_Click(object sender, EventArgs e)
        {
            int index = lbKnigi.SelectedIndex;
            if (index != -1)
            {
                string selectedBook = lbKnigi.SelectedItem.ToString();
                lbKosnicka.Items.Add(selectedBook);
                //lbKnigi.Items.RemoveAt(index);
                lbKnigi.SelectedIndex = -1;
            }
            
        }

        private void btnOtstraniKosnicka_Click(object sender, EventArgs e)
        {
            int index = lbKosnicka.SelectedIndex;
            if (index != -1)
            {
                lbKosnicka.Items.RemoveAt(index);
                lbKosnicka.SelectedIndex = -1;
            }
        }
    }
}
