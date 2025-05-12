using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Entities;
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

        /**
         * ======================
         *  SECTION UTILISATEURS
         * ======================
         */

        private void UpdateUserAccordion()
        {
            usersAccordion.Clear();

            var superadmins = usersRepository.GetAllByRole(UserRole.SUPERADMIN);
            var admins = usersRepository.GetAllByRole(UserRole.ADMIN);
            var managers = usersRepository.GetAllByRole(UserRole.MANAGER);
            var staffs = usersRepository.GetAllByRole(UserRole.STAFF);

            var superadminGroup = usersAccordion.AddGroup();
            superadminGroup.Text = "Super-Admins (" + superadmins.Count() + ")";

            var adminGroup = usersAccordion.AddGroup();
            adminGroup.Text = "Administrateurs (" + admins.Count() + ")";

            var managersGroup = usersAccordion.AddGroup();
            managersGroup.Text = "Managers (" + managers.Count() + ")";

            var staffGroup = usersAccordion.AddGroup();
            staffGroup.Text = "Staff (" + staffs.Count() + ")";

            foreach (User u in superadmins)
            {
                var e = usersAccordion.AddItem();
                e.Text = u.Fullname;
                e.Click += (o, ev) => EditUser(u);

                superadminGroup.Elements.Add(e);
            }

            foreach (User u in admins)
            {
                var e = usersAccordion.AddItem();
                e.Text = u.Fullname;

                adminGroup.Elements.Add(e);
                e.Click += (o, ev) => EditUser(u);
            }

            foreach (User u in managers)
            {
                var e = usersAccordion.AddItem();
                e.Text = u.Fullname;

                managersGroup.Elements.Add(e);
                e.Click += (o, ev) => EditUser(u);
            }

            foreach (User u in staffs)
            {
                var e = usersAccordion.AddItem();
                e.Text = u.Fullname;

                staffGroup.Elements.Add(e);
                e.Click += (o, ev) => EditUser(u);
            }
        }

        private void EditUser(User u)
        {
            // TODO Edit User Form
        }

        private void DashboardScreen_Shown(object sender, EventArgs e)
        {
            UpdateUserAccordion();
        }
    }
}