using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectPOSsystem
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Textfile is created and Screen-Writer tries to write details into file
                var sw = new System.IO.StreamWriter(txtRegisterUsername.Text + "\\login.ID");
                sw.Write(txtRegisterUsername.Text + "\n" + txtRegisterPassword.Text);
                sw.Close();
                MessageBox.Show("Success");
                this.Close();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                //If it cant find a directory to write to it writes its own directory
                System.IO.Directory.CreateDirectory(txtRegisterUsername.Text);
                var sw = new System.IO.StreamWriter(txtRegisterUsername.Text + "\\login.ID");
                sw.Write(txtRegisterUsername.Text + "\n" + txtRegisterPassword.Text);
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
        }

        private void txtRegisterUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ensuring that special characters arent typed
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
