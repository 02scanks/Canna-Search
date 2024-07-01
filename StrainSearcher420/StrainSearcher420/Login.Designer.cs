namespace StrainSearcher420
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.headerPanel = new ReaLTaiizor.Controls.Panel();
            this.controlBox = new ReaLTaiizor.Controls.ControlBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new ReaLTaiizor.Controls.BigLabel();
            this.passwordLabel = new ReaLTaiizor.Controls.BigLabel();
            this.loginButton = new ReaLTaiizor.Controls.AloneButton();
            this.sloganLabel = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            this.usernameInput = new ReaLTaiizor.Controls.BigTextBox();
            this.passwordInput = new ReaLTaiizor.Controls.BigTextBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(96)))), ((int)(((byte)(44)))));
            this.headerPanel.Controls.Add(this.controlBox);
            this.headerPanel.Controls.Add(this.smallLabel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.headerPanel.Size = new System.Drawing.Size(405, 28);
            this.headerPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.headerPanel.TabIndex = 2;
            this.headerPanel.Text = "panel1";
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(96)))), ((int)(((byte)(44)))));
            this.controlBox.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox.DefaultLocation = true;
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox.EnableHoverHighlight = true;
            this.controlBox.EnableMaximizeButton = false;
            this.controlBox.EnableMinimizeButton = true;
            this.controlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox.Location = new System.Drawing.Point(310, 5);
            this.controlBox.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(90, 25);
            this.controlBox.TabIndex = 5;
            this.controlBox.Text = "controlBox1";
            // 
            // smallLabel1
            // 
            this.smallLabel1.AutoSize = true;
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel1.ForeColor = System.Drawing.Color.White;
            this.smallLabel1.Location = new System.Drawing.Point(8, 3);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(100, 20);
            this.smallLabel1.TabIndex = 3;
            this.smallLabel1.Text = "Canna-Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StrainSearcher420.Properties.Resources.Leaf;
            this.pictureBox1.Location = new System.Drawing.Point(238, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.usernameLabel.Location = new System.Drawing.Point(12, 49);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(111, 30);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordLabel.Location = new System.Drawing.Point(12, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 30);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.EnabledCalc = true;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.loginButton.Location = new System.Drawing.Point(17, 203);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(152, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.loginButton_Click);
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.BackColor = System.Drawing.Color.Transparent;
            this.sloganLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.sloganLabel.Location = new System.Drawing.Point(185, 49);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(164, 25);
            this.sloganLabel.TabIndex = 11;
            this.sloganLabel.Text = "Your Guide to the ";
            // 
            // smallLabel2
            // 
            this.smallLabel2.AutoSize = true;
            this.smallLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(96)))), ((int)(((byte)(44)))));
            this.smallLabel2.Location = new System.Drawing.Point(263, 72);
            this.smallLabel2.Name = "smallLabel2";
            this.smallLabel2.Size = new System.Drawing.Size(98, 20);
            this.smallLabel2.TabIndex = 12;
            this.smallLabel2.Text = "Green World";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.Transparent;
            this.usernameInput.Font = new System.Drawing.Font("Tahoma", 11F);
            this.usernameInput.ForeColor = System.Drawing.Color.DimGray;
            this.usernameInput.Image = null;
            this.usernameInput.Location = new System.Drawing.Point(17, 82);
            this.usernameInput.MaxLength = 32767;
            this.usernameInput.Multiline = false;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.ReadOnly = false;
            this.usernameInput.Size = new System.Drawing.Size(143, 41);
            this.usernameInput.TabIndex = 13;
            this.usernameInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameInput.UseSystemPasswordChar = false;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.Font = new System.Drawing.Font("Tahoma", 11F);
            this.passwordInput.ForeColor = System.Drawing.Color.DimGray;
            this.passwordInput.Image = null;
            this.passwordInput.Location = new System.Drawing.Point(17, 152);
            this.passwordInput.MaxLength = 32767;
            this.passwordInput.Multiline = false;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.ReadOnly = false;
            this.passwordInput.Size = new System.Drawing.Size(143, 41);
            this.passwordInput.TabIndex = 14;
            this.passwordInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 255);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.smallLabel2);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.Panel headerPanel;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel usernameLabel;
        private ReaLTaiizor.Controls.BigLabel passwordLabel;
        private ReaLTaiizor.Controls.AloneButton loginButton;
        private ReaLTaiizor.Controls.SmallLabel sloganLabel;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.ControlBox controlBox;
        private ReaLTaiizor.Controls.BigTextBox usernameInput;
        private ReaLTaiizor.Controls.BigTextBox passwordInput;
    }
}

