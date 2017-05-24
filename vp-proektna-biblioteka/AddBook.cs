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
        public AddBook()
        {
            InitializeComponent();
            this.ActiveControl = tbNaslov;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            //this.booksTableAdapter.Fill(this.booksDataSet.Books);

        }

        public void dodadikniga()
        {
            //String query = "INSERT INTO [Books] (Id, Title, Author, Category) VALUES('" + tbId.Text + "','" + tbNaslov.Text + "','" + tbAvtor.Text + "','" + tbKategorija.Text + "')";
            String query = "INSERT INTO [Books] (Title, Author, Category, Content) VALUES(@Title, @Author, @Category, @Content)";
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);
            cmd.Parameters.AddWithValue("@Title", tbNaslov.Text);
            cmd.Parameters.AddWithValue("@Author", tbAvtor.Text);
            cmd.Parameters.AddWithValue("@Category", tbKategorija.Text);
            cmd.Parameters.AddWithValue("@Content", tbContent.Text);

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
        }

        private void tbNaslov_Validating(object sender, CancelEventArgs e)
        {
            string naslov = tbNaslov.Text;
            if (naslov.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNaslov, "Внеси наслов на книгата");
            }
            else
            {
                errorProvider1.SetError(tbNaslov, null);
            }
        }

        private void tbAvtor_Validating(object sender, CancelEventArgs e)
        {
            string avtor = tbAvtor.Text;
            if (avtor.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAvtor, "Внеси автор на книгата");
            }
            else
            {
                errorProvider1.SetError(tbAvtor, null);
            }
        }

        private void tbKategorija_Validating(object sender, CancelEventArgs e)
        {
            string kategorija = tbKategorija.Text;
            if (kategorija.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbKategorija, "Внеси категорија на книгата");
            }
            else
            {
                errorProvider1.SetError(tbKategorija, null);
            }
        }

        private void tbContent_Validating(object sender, CancelEventArgs e)
        {
            string content = tbContent.Text;
            if (content.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbContent, "Внеси содржина на книгата");
            }
            else
            {
                errorProvider1.SetError(tbContent, null);
            }
        }
    }
}
