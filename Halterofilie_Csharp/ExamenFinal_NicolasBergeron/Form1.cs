using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_NicolasBergeron
{
    public partial class Login : Form
    {
        private int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        //Check if the eye(label) is click, if yes the PassWordChar change so that the user can see what he/she wrote.
        private void lblSeePwd_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 != 0)            
              txtPwd.PasswordChar = '\0';
            
            else            
              txtPwd.PasswordChar = '*';             
        }

        //On load of page, the button login can be click we Enter and the textboxs have a string put in it.
        private void Login_Load(object sender, EventArgs e)
        {
            ActiveControl = pillBtnLogin;
            this.AcceptButton = pillBtnLogin;
            txtUser.Text = "Nom utilisateur ...";
            txtPwd.Text = "Mot de passe ..."; 
        }

        //Check if the user and password are (bob) if yes, then next form is load if not error message.
        private void pillBtnLogin_Click(object sender, EventArgs e)
        {
            string utilisateur = txtUser.Text.Trim();
            string motPasse = txtPwd.Text.Trim();

            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
            {
                if (utilisateur == "bob" && motPasse == "bob")
                {
                    this.Hide();
                    MainPage mPage = new MainPage();                    
                    mPage.Closed += (s, args) => this.Close();
                    mPage.Show();
                }
                else
                {
                    MessageBox.Show("Les informations saisie ne sont pas valides.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    txtUser.Text = String.Empty;
                    txtPwd.Text = "Mot de passe ...";
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe!", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                txtPwd.Text = "Mot de passe ...";

            }
        }

        //Check if textbox user is click if click, text inside become "" and the font color become black.
        private void txtUser_Enter(object sender, EventArgs e)
        {               
            if (txtUser.Text == "Nom utilisateur ...")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        //Check if textbox password is click if click, text inside become "" and the font color become black.
        //and PasswordChar become *.
        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "Mot de passe ...")
            {
                txtPwd.Text = "";
                txtPwd.ForeColor = Color.Black;
            }

            txtPwd.PasswordChar = '*';            
        }
    }
}