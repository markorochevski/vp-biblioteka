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
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDataSet.Books);

        }

        public void dodadikniga()
        {
            string naslov = tbNaslov.Text;
            string avtor = tbAvtor.Text;
            string kategorija = tbKategorija.Text;

            string naredba = "INSERT INTO Books (Id, Title, Author, Category) VALUES (@Id, @Title, @Author, @Category)";
            string conStr = "Data Source=(LocalDB)\v11.0;AttachDbFilename=\"c:\\users\\rochevski\\documents\\visual studio 2013\\Projects\\vp-proektna-biblioteka\\vp-proektna-biblioteka\\Books.mdf\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(naredba, conn);
            cmd.Parameters.AddWithValue("@Id", 15);
            cmd.Parameters.AddWithValue("@Title", naslov);
            cmd.Parameters.AddWithValue("@Author", avtor);
            cmd.Parameters.AddWithValue("@Category", kategorija);
            int n = 0;
            try
            {
                conn.Open();
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                if (n != 0)
                {
                    MessageBox.Show("success");
                }
            }
            Close();
        }

    }
}
