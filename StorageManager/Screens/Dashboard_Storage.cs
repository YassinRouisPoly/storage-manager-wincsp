using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.Screens
{
    public partial class Dashboard_Storage : DevExpress.XtraEditors.XtraUserControl
    {
        IServiceProvider _serviceProvider;
        public Dashboard_Storage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
    }
}
