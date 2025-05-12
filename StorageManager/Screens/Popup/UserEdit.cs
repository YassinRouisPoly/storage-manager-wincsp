using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.Screens.Popup
{
    public partial class UserEdit : DevExpress.XtraEditors.XtraForm
    {
        public UserEdit(User user, bool editMode = false)
        {
            InitializeComponent();
            userBindingSource.DataSource = user;

            comboBoxEdit1.Properties.Items.Clear();
            comboBoxEdit1.Properties.Items.Add("SUPERADMIN");
            comboBoxEdit1.Properties.Items.Add("ADMIN");
            comboBoxEdit1.Properties.Items.Add("MANAGER");
            comboBoxEdit1.Properties.Items.Add("STAFF");

            if (!editMode)
            {
                titleLabel.Text = "Créer un utilisateur";
                removeBtn.Hide();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}