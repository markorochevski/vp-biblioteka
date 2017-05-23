using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_proektna_biblioteka
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;

            MessageBox.Show(name + " вашата нарачка ќе пристигне на адреса " + address + " за 2-3 работни дена. Ти благодариме!",
                "Нарачката е комплетирана");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
