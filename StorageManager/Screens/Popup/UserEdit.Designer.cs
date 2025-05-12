namespace StorageManager.Screens.Popup
{
    partial class UserEdit
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
            components = new System.ComponentModel.Container();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            userBindingSource = new BindingSource(components);
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(156, 154);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.PasswordChar = '•';
            textEdit1.Size = new Size(216, 20);
            textEdit1.TabIndex = 0;
            textEdit1.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // dropDownButton1
            // 
            dropDownButton1.DataBindings.Add(new Binding("Text", userBindingSource, "Role", true));
            dropDownButton1.Location = new Point(156, 80);
            dropDownButton1.Name = "dropDownButton1";
            dropDownButton1.Size = new Size(216, 23);
            dropDownButton1.TabIndex = 1;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Data.Entities.User);
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("Text", userBindingSource, "Fullname", true));
            textEdit2.Location = new Point(156, 54);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(216, 20);
            textEdit2.TabIndex = 2;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("Tag", userBindingSource, "Username", true));
            textEdit3.Location = new Point(156, 128);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(216, 20);
            textEdit3.TabIndex = 3;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("Text", userBindingSource, "Id", true));
            textEdit4.Location = new Point(156, 9);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(72, 20);
            textEdit4.TabIndex = 4;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(52, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(98, 13);
            labelControl1.TabIndex = 5;
            labelControl1.Text = "ID :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(52, 61);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(98, 13);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Nom complet :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.Location = new Point(52, 85);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(98, 13);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Rôle :";
            labelControl3.Click += labelControl3_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.Location = new Point(52, 157);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(98, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Mot de passe :";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.Location = new Point(52, 133);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(98, 13);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "Nom d'utilisateur :";
            // 
            // simpleButton1
            // 
            simpleButton1.DialogResult = DialogResult.OK;
            simpleButton1.Location = new Point(52, 208);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(320, 23);
            simpleButton1.TabIndex = 10;
            simpleButton1.Text = "Valider";
            // 
            // simpleButton2
            // 
            simpleButton2.DialogResult = DialogResult.OK;
            simpleButton2.Location = new Point(52, 235);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(320, 23);
            simpleButton2.TabIndex = 11;
            simpleButton2.Text = "Annuler";
            // 
            // UserEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 296);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl4);
            Controls.Add(labelControl5);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(dropDownButton1);
            Controls.Add(textEdit1);
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEdit";
            Load += UserEdit_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private BindingSource userBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}