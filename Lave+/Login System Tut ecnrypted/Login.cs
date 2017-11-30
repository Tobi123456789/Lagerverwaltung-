using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AesEncDec;
using System.IO;

namespace Login_System_Tut_ecnrypted
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrTxt.Text.Length < 3 || passTxt.Text.Length < 5)
            {
                MessageBox.Show("Falscher Benutzername oder Passwort");
                regform reg = new regform();
                reg.Show();
            }
            else
            {
                string dir = usrTxt.Text;
                User usr = new User();

                string encusr = usr.benutzername;
                string encpass = usr.passwort;
                bool recht = usr.recht;

                string decusr = AesCryp.Decrypt(encusr);
                string decpass = AesCryp.Decrypt(encpass);

                    if (decusr == usrTxt.Text && decpass == passTxt.Text)
                    {
                        MessageBox.Show("Welcome {0} to the private area!", decusr);
                        main main = new main();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                    }
                }
            }
        }
    }
