namespace StorageManager
{
    partial class LoginForm
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
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            directxFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            directxFormContainerControl1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = Properties.Resources.login_background1;
            pictureEdit1.Location = new Point(3, 3);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.PictureAlignment = ContentAlignment.BottomLeft;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(452, 538);
            pictureEdit1.TabIndex = 0;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(497, 209);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(313, 20);
            textEdit1.TabIndex = 1;
            textEdit1.ToolTip = "Nom d'utilisateur";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(497, 258);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.PasswordChar = '•';
            textEdit2.Size = new Size(313, 20);
            textEdit2.TabIndex = 2;
            // 
            // directxFormContainerControl1
            // 
            directxFormContainerControl1.Controls.Add(labelControl3);
            directxFormContainerControl1.Controls.Add(textEdit1);
            directxFormContainerControl1.Controls.Add(simpleButton1);
            directxFormContainerControl1.Controls.Add(labelControl2);
            directxFormContainerControl1.Controls.Add(labelControl1);
            directxFormContainerControl1.Controls.Add(textEdit2);
            directxFormContainerControl1.Location = new Point(1, 31);
            directxFormContainerControl1.Name = "directxFormContainerControl1";
            directxFormContainerControl1.Size = new Size(850, 512);
            directxFormContainerControl1.TabIndex = 4;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(593, 87);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(119, 29);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Connexion";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            simpleButton1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseBorderColor = true;
            simpleButton1.Location = new Point(497, 355);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(313, 23);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "Se connecter";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(497, 237);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(78, 15);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Mot de passe";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(497, 188);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(99, 15);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Nom d'utilisateur";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ChildControls.Add(pictureEdit1);
            ChildControls.Add(directxFormContainerControl1);
            ClientSize = new Size(852, 544);
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MaximumSize = new Size(852, 544);
            MinimumSize = new Size(852, 544);
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            directxFormContainerControl1.ResumeLayout(false);
            directxFormContainerControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.DirectXFormContainerControl directxFormContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}