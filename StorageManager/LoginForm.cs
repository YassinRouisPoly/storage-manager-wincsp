using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Repositories;
using StorageManager.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class LoginForm : DevExpress.XtraEditors.DirectXForm
    {
        IServiceProvider serviceProvider;
        AuthenticationService authenticationService;

        public LoginForm()
        {
            InitializeComponent();
            serviceProvider = Program.ServiceProvider;
            authenticationService = serviceProvider.GetRequiredService<AuthenticationService>();
            errorLabel.Hide();
        }

        private void OnShown(object sender, EventArgs e)
        {
            usernameInput.Focus();
        }

        private void ShowError(string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Show();
        }

        private void ShowInfo(string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.LightGray;
            errorLabel.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            ShowInfo("Connexion en cours ...");
            if (authenticationService.Login(usernameInput.Text, passwordInput.Text))
            {
                // TODO Go to Dashboard
            }
            else
            {
                ShowError("Nom d'utilisateur ou mot de passe incorrecte.");
                passwordInput.Text = "";
                usernameInput.Focus();
            }
        }

        private void CheckEnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AttemptLogin();
            }
        }

        private void CheckEnterPressed_Username(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                passwordInput.Focus();
            }
        }

        private void CheckEnterPressed_Password(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AttemptLogin();
            }
        }
    }
}