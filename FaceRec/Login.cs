using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        FrmPrincipal frm = new FrmPrincipal();

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbId.Text.Length >= 4 && txbPw.Text.Length >= 4)
            {

                frm.disPlayData();
                frm.Show();
                

                // frm.Hide();


                //frm.Load += new EventHandler(frm.FrmPrincipal_Load);
                // check = false;

                //MessageBox.Show("login");


                //this.Show();
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Login faild", "Error");
                
            }                                 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = btnLogin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Succes!", "Cancel");
                this.Close();
                frm.Show();
                
            }
            else
            {
                this.Activate();
            }
        }
    }

}
