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
            this.ActiveControl = tbName;
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string phone = mtbNumber.Text;

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

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string name = tbName.Text;
            if (name.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Внеси го своето име и презиме");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            string address = tbAddress.Text;
            if (address.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAddress, "Внеси ја својата адреса");
            }
            else
            {
                errorProvider1.SetError(tbAddress, null);
            }
        }

        private void mtbNumber_Validating(object sender, CancelEventArgs e)
        {
            string number = mtbNumber.Text;
            if (number.Trim().Length != 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbNumber, "Бројот мора да содржи точно 9 цифри");
            }
            else
            {
                errorProvider1.SetError(mtbNumber, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbEmail.Text, out errorMsg))
            {
                // Cancel the event.
                e.Cancel = true;
                // Set the ErrorProvider error with the text to display.
                errorProvider1.SetError(tbEmail, errorMsg);
            }
            else
                errorProvider1.SetError(tbEmail, "");
        
    }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.Length == 0)
            {
                errorMessage = "Внеси го својот е-mail";
                return false;
            }
            // Confirm that there is an "@" and a "." in the e-mail address,
            // and in the correct order.
            int atpos;
            if ((atpos = emailAddress.IndexOf("@")) > -1)
            {
                if (emailAddress.IndexOf(".", atpos) > atpos &&
                emailAddress.IndexOf("@", atpos + 1) <= atpos)
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "e-mail адресата мора да биде во валиден формат \n" +
            "Пример: 'someone@example.com' ";
            return false;
        }
    }
}
