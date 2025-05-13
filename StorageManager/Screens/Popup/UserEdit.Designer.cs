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
            confirmBtn = new DevExpress.XtraEditors.SimpleButton();
            cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            titleLabel = new DevExpress.XtraEditors.LabelControl();
            roleSource = new BindingSource(components);
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            removeBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("Text", userBindingSource, "PasswordHash", true));
            textEdit1.Location = new Point(151, 210);
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
            textEdit2.Location = new Point(151, 110);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(216, 20);
            textEdit2.TabIndex = 2;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("Text", userBindingSource, "Username", true));
            textEdit3.Location = new Point(151, 184);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(216, 20);
            textEdit3.TabIndex = 3;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("Text", userBindingSource, "Id", true));
            textEdit4.Enabled = false;
            textEdit4.Location = new Point(151, 65);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(72, 20);
            textEdit4.TabIndex = 4;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(47, 68);
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
            labelControl2.Location = new Point(47, 117);
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
            labelControl3.Location = new Point(47, 141);
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
            labelControl4.Location = new Point(47, 213);
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
            labelControl5.Location = new Point(47, 189);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(98, 13);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "Nom d'utilisateur :";
            // 
            // confirmBtn
            // 
            confirmBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            confirmBtn.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            confirmBtn.Appearance.Options.UseBackColor = true;
            confirmBtn.Appearance.Options.UseBorderColor = true;
            confirmBtn.DialogResult = DialogResult.OK;
            confirmBtn.Location = new Point(47, 289);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(320, 23);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "Valider";
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(47, 317);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(320, 23);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Annuler";
            // 
            // titleLabel
            // 
            titleLabel.Appearance.Font = new Font("Montserrat", 16F);
            titleLabel.Appearance.Options.UseFont = true;
            titleLabel.Appearance.Options.UseTextOptions = true;
            titleLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            titleLabel.Location = new Point(12, -4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(387, 40);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Modifier un utilisateur";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.DataBindings.Add(new Binding("Text", userBindingSource, "Role", true));
            comboBoxEdit1.Location = new Point(151, 138);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(216, 20);
            comboBoxEdit1.TabIndex = 13;
            // 
            // removeBtn
            // 
            removeBtn.Appearance.BackColor = Color.Red;
            removeBtn.Appearance.BorderColor = Color.DarkRed;
            removeBtn.Appearance.Options.UseBackColor = true;
            removeBtn.Appearance.Options.UseBorderColor = true;
            removeBtn.DialogResult = DialogResult.No;
            removeBtn.Location = new Point(47, 260);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(320, 23);
            removeBtn.TabIndex = 14;
            removeBtn.Text = "Supprimer";
            // 
            // UserEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 363);
            Controls.Add(removeBtn);
            Controls.Add(comboBoxEdit1);
            Controls.Add(titleLabel);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
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
            ((System.ComponentModel.ISupportInitialize)roleSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton confirmBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private BindingSource roleSource;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton removeBtn;
    }
}