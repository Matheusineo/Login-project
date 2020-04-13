using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_project
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "emailtop@123.com" && txtPassword.Text == "123456")
                {
                MessageBox.Show("Seja bem vindo usuario.");
                }
            else
            {
                MessageBox.Show("Informações invalidas.");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
