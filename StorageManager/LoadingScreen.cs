using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class LoadingScreen : SplashScreen
    {
        public LoadingScreen()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Un projet ROUIS, KAMEL, AMARA © " + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        private async void LoadingScreen_Shown(object sender, EventArgs e)
        {
            await Task.Delay(2000);

            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();

            form.FormClosed += this.CloseForm;
        }

        public enum SplashScreenCommand
        {
        }

        private void CloseForm(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}