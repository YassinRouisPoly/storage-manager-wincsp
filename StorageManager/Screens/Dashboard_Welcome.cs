using DevExpress.XtraEditors;
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
    public partial class Dashboard_Welcome : DevExpress.XtraEditors.XtraUserControl
    {
        IServiceProvider serviceProvider;
   

        public Dashboard_Welcome(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Welcome_Load(object sender, EventArgs e)
        {
            productTransferBindingSource.DataSource =; 
        }
    }
}
