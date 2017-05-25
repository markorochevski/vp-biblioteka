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
    public partial class ShowDetails : Form
    {
        public int detailsID;
        public ShowDetails(string selectedTitle)
        {
            InitializeComponent();

            String query = "SELECT * FROM [Books] WHERE Title='" + selectedTitle + "'";
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(query, konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                reader.Read();
                string naslov = reader["Title"].ToString();
                string avtor = reader["Author"].ToString();
                string kategorija = reader["Category"].ToString();
                string content = reader["Content"].ToString();
                lblTitle.Text = naslov;
                lblAuthor.Text = avtor;
                lblCategory.Text = kategorija;
                lblContent.Text = content;
                
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
    }
}
