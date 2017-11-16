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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length < 3 || txt_passwort.Text.Length < 5 || txt_passwort==txt_passwort_wh)
            {
                MessageBox.Show("Benutzername oder Passwort zu kurz!");
            }
            else
            {
                string dir = txt_username.Text;
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = AesCryp.Encrypt(txt_username.Text);
                string encpass = AesCryp.Encrypt(txt_passwort.Text);

                sw.WriteLine(encusr);
                sw.WriteLine(encpass);
                sw.Close();

                MessageBox.Show("Benutzer '" + dir + "' wurde erstellt!", txt_username.Text);
                this.Close();
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
