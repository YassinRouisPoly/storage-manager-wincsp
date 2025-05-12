using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;
using StorageManager.Screens;
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
    public partial class DashboardScreen : DevExpress.XtraEditors.XtraForm
    {
        UsersRepository usersRepository;
        IServiceProvider _serviceProvider;

        public DashboardScreen(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            usersRepository = serviceProvider.GetRequiredService<UsersRepository>();
        }

        private void DashboardScreen_Shown(object sender, EventArgs e)
        {
            xtraTransferts.Controls.Clear();
            xtraTransferts.Controls.Add(new Dashboard_Transfers(_serviceProvider));
            xtraUtilisateurs.Controls.Clear();
            xtraUtilisateurs.Controls.Add(new Dashboard_Users(_serviceProvider));
            xtraStockage.Controls.Clear();
            xtraStockage.Controls.Add(new Dashboard_Storage(_serviceProvider));
            xtraAccueil.Controls.Clear();
            xtraAccueil.Controls.Add(new Dashboard_Home(_serviceProvider));
        }
    }
}