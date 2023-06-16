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
    public partial class frmLoginRegister : Form
    {
        //Declaring variables to be used
        public string username, password;
        public frmLoginRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide Login form and show Register form
            FrmRegister f2 = new FrmRegister();
            f2.Hide();
            FrmRegister f3 = new FrmRegister();
            f3.Show();
        }


        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            // We leave touch ID for the 3rd years
             ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.pctrTouchID, "HAHA, maybe next time");
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            //Importing picture to picturebox
            pctrLogin.Image = Image.FromFile(Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                   + "\\Images\\BCPOSLogo.png");
        }

        private void txtLoginUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ensuring that special characters arent typed
            if ( !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) )
            {
            
                e.Handled = true;
            }
            btnLogin.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Screen-Reader reads the username and password from the created textfile
                var sr = new System.IO.StreamReader(txtLoginUsername.Text + "\\login.ID");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                //If the values match a message is displayed and user is directed to form2
                if (username == txtLoginUsername.Text && password == txtLoginPassword.Text)
                {
                    MessageBox.Show("You are now successfully logged in ", "Success!");
                    frmPOS f1 = new frmPOS();
                    
                    f1.Show();
                 
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong", "Error");
                }
            }
            //If the created textfile cant be found it means the user hasnt registered yet
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("The username and password combination doesn't exist.\n" +
                                                " Please try and Register if you haven't registered before", "Error");
           
            }
        }
    }
}
