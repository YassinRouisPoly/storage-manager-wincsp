namespace StorageManager
{
    partial class DashboardScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardScreen));
            tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            accueil = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            transferts = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            stockage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            Utilisateurs = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            usersAccordion = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControl_administrateurs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControl_manager = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControl_staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            createUserButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)tabPane1).BeginInit();
            tabPane1.SuspendLayout();
            accueil.SuspendLayout();
            transferts.SuspendLayout();
            stockage.SuspendLayout();
            Utilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersAccordion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane1
            // 
            tabPane1.Controls.Add(accueil);
            tabPane1.Controls.Add(transferts);
            tabPane1.Controls.Add(stockage);
            tabPane1.Controls.Add(Utilisateurs);
            tabPane1.Dock = DockStyle.Fill;
            tabPane1.Location = new Point(0, 0);
            tabPane1.Name = "tabPane1";
            tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { accueil, transferts, stockage, Utilisateurs });
            tabPane1.RegularSize = new Size(842, 546);
            tabPane1.SelectedPage = accueil;
            tabPane1.Size = new Size(842, 546);
            tabPane1.TabIndex = 0;
            tabPane1.Text = "tabPane1";
            // 
            // accueil
            // 
            accueil.Caption = "Accueil";
            accueil.Controls.Add(labelControl4);
            accueil.ImageOptions.SvgImage = Properties.Resources.Home;
            accueil.ImageOptions.SvgImageSize = new Size(16, 16);
            accueil.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            accueil.Name = "accueil";
            accueil.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            accueil.Size = new Size(842, 513);
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(0, 0);
            labelControl4.Name = "labelControl4";
            labelControl4.Padding = new Padding(20);
            labelControl4.Size = new Size(164, 77);
            labelControl4.TabIndex = 2;
            labelControl4.Text = "ACCUEIL";
            // 
            // transferts
            // 
            transferts.Caption = "Transferts";
            transferts.Controls.Add(labelControl1);
            transferts.ImageOptions.SvgImage = Properties.Resources.Transfers;
            transferts.ImageOptions.SvgImageSize = new Size(16, 16);
            transferts.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            transferts.Name = "transferts";
            transferts.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            transferts.Size = new Size(1201, 591);
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(0, 0);
            labelControl1.Name = "labelControl1";
            labelControl1.Padding = new Padding(20);
            labelControl1.Size = new Size(223, 77);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "TRANSFERTS";
            // 
            // stockage
            // 
            stockage.Caption = "Stockage";
            stockage.Controls.Add(labelControl2);
            stockage.ImageOptions.SvgImage = Properties.Resources.Storage;
            stockage.ImageOptions.SvgImageSize = new Size(16, 16);
            stockage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            stockage.Name = "stockage";
            stockage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            stockage.Size = new Size(842, 513);
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(0, 0);
            labelControl2.Name = "labelControl2";
            labelControl2.Padding = new Padding(20);
            labelControl2.Size = new Size(195, 77);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "STOCKAGE";
            // 
            // Utilisateurs
            // 
            Utilisateurs.Caption = "Utilisateurs";
            Utilisateurs.Controls.Add(tablePanel2);
            Utilisateurs.Controls.Add(labelControl3);
            Utilisateurs.ImageOptions.SvgImage = Properties.Resources.Profile;
            Utilisateurs.ImageOptions.SvgImageSize = new Size(16, 16);
            Utilisateurs.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            Utilisateurs.Name = "Utilisateurs";
            Utilisateurs.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            Utilisateurs.Size = new Size(842, 513);
            // 
            // usersAccordion
            // 
            tablePanel2.SetColumn(usersAccordion, 0);
            usersAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControl_administrateurs, accordionControl_manager, accordionControl_staff });
            usersAccordion.Location = new Point(13, 12);
            usersAccordion.Name = "usersAccordion";
            usersAccordion.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            tablePanel2.SetRow(usersAccordion, 0);
            usersAccordion.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            usersAccordion.Size = new Size(407, 366);
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
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(0, 0);
            labelControl3.Name = "labelControl3";
            labelControl3.Padding = new Padding(20);
            labelControl3.Size = new Size(240, 77);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "UTILISATEURS";
            // 
            // tablePanel2
            // 
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel2.Controls.Add(createUserButton);
            tablePanel2.Controls.Add(usersAccordion);
            tablePanel2.Location = new Point(209, 83);
            tablePanel2.Name = "tablePanel2";
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
            tablePanel2.Size = new Size(433, 418);
            tablePanel2.TabIndex = 4;
            tablePanel2.UseSkinIndents = true;
            // 
            // createUserButton
            // 
            tablePanel2.SetColumn(createUserButton, 0);
            createUserButton.Location = new Point(13, 382);
            createUserButton.Name = "createUserButton";
            tablePanel2.SetRow(createUserButton, 1);
            createUserButton.Size = new Size(407, 23);
            createUserButton.TabIndex = 4;
            createUserButton.Text = "Créer un utilisateur";
            // 
            // DashboardScreen
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 546);
            Controls.Add(tabPane1);
            IconOptions.Icon = (Icon)resources.GetObject("DashboardScreen.IconOptions.Icon");
            Name = "DashboardScreen";
            Text = "Storage Manager (v0.1)";
            Shown += DashboardScreen_Shown;
            ((System.ComponentModel.ISupportInitialize)tabPane1).EndInit();
            tabPane1.ResumeLayout(false);
            accueil.ResumeLayout(false);
            accueil.PerformLayout();
            transferts.ResumeLayout(false);
            transferts.PerformLayout();
            stockage.ResumeLayout(false);
            stockage.PerformLayout();
            Utilisateurs.ResumeLayout(false);
            Utilisateurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersAccordion).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage accueil;
        private DevExpress.XtraBars.Navigation.TabNavigationPage transferts;
        private DevExpress.XtraBars.Navigation.TabNavigationPage stockage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Utilisateurs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl usersAccordion;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_administrateurs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_manager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControl_staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton createUserButton;
    }
}