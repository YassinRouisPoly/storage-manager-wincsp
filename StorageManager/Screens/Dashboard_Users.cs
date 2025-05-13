using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;
using StorageManager.Screens.Popup;
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
    public partial class Dashboard_Users : DevExpress.XtraEditors.XtraUserControl
    {

        IServiceProvider _serviceProvider;
        UsersRepository usersRepository;

        public Dashboard_Users(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            usersRepository = serviceProvider.GetRequiredService<UsersRepository>();
        }

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
            var oldPassword = u.PasswordHash;
            var dialogForm = new UserEdit(u, true);
            var dialogResult = dialogForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if (u.PasswordHash != oldPassword)
                {
                    u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(u.PasswordHash);
                }
                usersRepository.Update(u);
                UpdateUserAccordion();
            }
            else if (dialogResult == DialogResult.Abort)
            {
                usersRepository.Delete(u.Id);
            }
        }

        private void Dashboard_Users_Paint(object sender, PaintEventArgs e)
        {
            UpdateUserAccordion();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            User u = new();
            var dialogForm = new UserEdit(u);
            var dialogResult = dialogForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(u.PasswordHash);
                usersRepository.Add(u);
                UpdateUserAccordion();
            }
        }
    }
}
