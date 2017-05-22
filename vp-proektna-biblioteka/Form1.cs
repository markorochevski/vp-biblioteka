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
            String query = "SELECT ID, Title, Author, Category FROM dbo.Books";
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=\"C:\\Users\\Rochevski\\documents\\visual studio 2013\\Projects\\vp-proektna-biblioteka\\vp-proektna-biblioteka\\Books.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //ListItem item = new ListItem();
                   // item.Text = reader["au_fname"].ToString() + " " + reader["au_lname"].ToString();
                   // item.Value = reader["au_id"].ToString();
                    string item = reader["Title"].ToString();
                    lbKosnicka.Items.Add(item);
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

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDataSet.Books);
        }


    }
}
