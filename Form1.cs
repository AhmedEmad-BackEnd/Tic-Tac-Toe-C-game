using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X__O_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin"&&txtPass.Text=="123")
            {
                MessageBox.Show("logged in Successfully","logged in",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form frm =new frmGame();
                frm.ShowDialog();
                this.Close();
            }
            else if(txtUserName.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("User Name / Password  Canot be empty", "login Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Clear();
                txtUserName.Clear();
            }
            else
            {
                MessageBox.Show("Faild to log in", "login Faild", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPass.Clear();
                txtUserName.Clear();
            }



        }
    }
}
