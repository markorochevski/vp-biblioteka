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

namespace vp_proektna_biblioteka
{
    public partial class AddBook : Form
    {
        Form1 f1;
        public AddBook()
        {
            InitializeComponent();
            f1 = new Form1();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            //this.booksTableAdapter.Fill(this.booksDataSet.Books);

        }

        public void dodadikniga()
        {
            String query = "INSERT INTO [Books] (Id, Title, Author, Category) VALUES('" + tbId.Text + "','" + tbNaslov.Text + "','" + tbAvtor.Text + "','" + tbKategorija.Text + "')";
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);
            try
            {
                konekcija.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnDodadiZacuvaj_Click(object sender, EventArgs e)
        {
            dodadikniga();
            //f1.Ispolni();
        }
    }
}
