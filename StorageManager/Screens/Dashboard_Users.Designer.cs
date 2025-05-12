namespace StorageManager.Screens
{
    partial class Dashboard_Users
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            createUserButton = new DevExpress.XtraEditors.SimpleButton();
            usersAccordion = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControl_administrateurs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControl_manager = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControl_staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersAccordion).BeginInit();
            SuspendLayout();
            // 
            // tablePanel2
            // 
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel2.Controls.Add(createUserButton);
            tablePanel2.Controls.Add(usersAccordion);
            tablePanel2.Dock = DockStyle.Fill;
            tablePanel2.Location = new Point(0, 0);
            tablePanel2.Name = "tablePanel2";
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
            tablePanel2.Size = new Size(1204, 538);
            tablePanel2.TabIndex = 6;
            tablePanel2.UseSkinIndents = true;
            // 
            // createUserButton
            // 
            createUserButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            createUserButton.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            createUserButton.Appearance.Options.UseBackColor = true;
            createUserButton.Appearance.Options.UseBorderColor = true;
            tablePanel2.SetColumn(createUserButton, 0);
            createUserButton.Location = new Point(13, 497);
            createUserButton.Name = "createUserButton";
            tablePanel2.SetRow(createUserButton, 1);
            createUserButton.Size = new Size(1178, 28);
            createUserButton.TabIndex = 4;
            createUserButton.Text = "Créer un utilisateur";
            createUserButton.Click += createUserButton_Click;
            // 
            // usersAccordion
            // 
            tablePanel2.SetColumn(usersAccordion, 0);
            usersAccordion.Dock = DockStyle.Fill;
            usersAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControl_administrateurs, accordionControl_manager, accordionControl_staff });
            usersAccordion.Location = new Point(13, 12);
            usersAccordion.Name = "usersAccordion";
            usersAccordion.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            tablePanel2.SetRow(usersAccordion, 0);
            usersAccordion.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            usersAccordion.Size = new Size(1178, 481);
            usersAccordion.TabIndex = 3;
            // 
            // accordionControl_administrateurs
            // 
            accordionControl_administrateurs.Name = "accordionControl_administrateurs";
            accordionControl_administrateurs.Text = "Administrateurs";
            // 
            // accordionControl_manager
            // 
            accordionControl_manager.Expanded = true;
            accordionControl_manager.Name = "accordionControl_manager";
            accordionControl_manager.Text = "Manager";
            // 
            // accordionControl_staff
            // 
            accordionControl_staff.Expanded = true;
            accordionControl_staff.Name = "accordionControl_staff";
            accordionControl_staff.Text = "Staff";
            // 
            // Dashboard_Users
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablePanel2);
            Name = "Dashboard_Users";
            Size = new Size(1204, 538);
            Paint += Dashboard_Users_Paint;
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersAccordion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton createUserButton;
        private DevExpress.XtraBars.Navigation.AccordionControl usersAccordion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_administrateurs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_manager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_staff;
    }
}
