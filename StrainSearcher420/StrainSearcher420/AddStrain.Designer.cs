namespace StrainSearcher420
{
    partial class AddStrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStrain));
            this.headerPanel = new ReaLTaiizor.Controls.Panel();
            this.controlBox = new ReaLTaiizor.Controls.ControlBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new ReaLTaiizor.Controls.BigLabel();
            this.passwordLabel = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.addStrainButton = new ReaLTaiizor.Controls.AloneButton();
            this.addImageButton = new ReaLTaiizor.Controls.AloneButton();
            this.strainImageDisplay = new System.Windows.Forms.PictureBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.strainComboBox = new ReaLTaiizor.Controls.AloneComboBox();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.strainNameInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.effectInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.tasteInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.negativesInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.thcInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.cbdInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.ratingInputBox = new ReaLTaiizor.Controls.BigTextBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strainImageDisplay)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(765, 28);
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
            this.controlBox.Location = new System.Drawing.Point(670, 5);
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
            this.smallLabel1.Size = new System.Drawing.Size(182, 20);
            this.smallLabel1.TabIndex = 3;
            this.smallLabel1.Text = "Canna-Search | Add Strain";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StrainSearcher420.Properties.Resources.Leaf;
            this.pictureBox1.Location = new System.Drawing.Point(557, 179);
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
            this.usernameLabel.Size = new System.Drawing.Size(74, 30);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordLabel.Location = new System.Drawing.Point(13, 129);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Effects:";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(13, 222);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(78, 20);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Negatives:";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(195, 59);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(56, 20);
            this.bigLabel2.TabIndex = 10;
            this.bigLabel2.Text = "THC %:";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(287, 59);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(53, 20);
            this.bigLabel3.TabIndex = 12;
            this.bigLabel3.Text = "CBD%:";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(272, 129);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(45, 20);
            this.bigLabel4.TabIndex = 15;
            this.bigLabel4.Text = "Taste:";
            // 
            // addStrainButton
            // 
            this.addStrainButton.BackColor = System.Drawing.Color.Transparent;
            this.addStrainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStrainButton.EnabledCalc = true;
            this.addStrainButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addStrainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.addStrainButton.Location = new System.Drawing.Point(276, 245);
            this.addStrainButton.Name = "addStrainButton";
            this.addStrainButton.Size = new System.Drawing.Size(234, 59);
            this.addStrainButton.TabIndex = 16;
            this.addStrainButton.Text = "Add Strain";
            this.addStrainButton.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.addStrainButton_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.Color.Transparent;
            this.addImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImageButton.EnabledCalc = true;
            this.addImageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.addImageButton.Location = new System.Drawing.Point(590, 189);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(163, 40);
            this.addImageButton.TabIndex = 18;
            this.addImageButton.Text = "Add Image";
            this.addImageButton.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.addImageButton_Click);
            // 
            // strainImageDisplay
            // 
            this.strainImageDisplay.BackColor = System.Drawing.Color.White;
            this.strainImageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strainImageDisplay.Location = new System.Drawing.Point(590, 49);
            this.strainImageDisplay.Name = "strainImageDisplay";
            this.strainImageDisplay.Size = new System.Drawing.Size(163, 134);
            this.strainImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.strainImageDisplay.TabIndex = 17;
            this.strainImageDisplay.TabStop = false;
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(379, 57);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(99, 20);
            this.bigLabel5.TabIndex = 22;
            this.bigLabel5.Text = "Rating (0 / 5):";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // strainComboBox
            // 
            this.strainComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strainComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.strainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strainComboBox.EnabledCalc = true;
            this.strainComboBox.FormattingEnabled = true;
            this.strainComboBox.ItemHeight = 20;
            this.strainComboBox.Items.AddRange(new object[] {
            "",
            "Hybrid",
            "Sativa",
            "Indica"});
            this.strainComboBox.Location = new System.Drawing.Point(506, 75);
            this.strainComboBox.Name = "strainComboBox";
            this.strainComboBox.Size = new System.Drawing.Size(64, 26);
            this.strainComboBox.TabIndex = 24;
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel6.Location = new System.Drawing.Point(505, 54);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(43, 20);
            this.bigLabel6.TabIndex = 25;
            this.bigLabel6.Text = "Type:";
            // 
            // strainNameInputBox
            // 
            this.strainNameInputBox.BackColor = System.Drawing.Color.Transparent;
            this.strainNameInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.strainNameInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.strainNameInputBox.Image = null;
            this.strainNameInputBox.Location = new System.Drawing.Point(17, 80);
            this.strainNameInputBox.MaxLength = 32767;
            this.strainNameInputBox.Multiline = false;
            this.strainNameInputBox.Name = "strainNameInputBox";
            this.strainNameInputBox.ReadOnly = false;
            this.strainNameInputBox.Size = new System.Drawing.Size(153, 41);
            this.strainNameInputBox.TabIndex = 26;
            this.strainNameInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.strainNameInputBox.UseSystemPasswordChar = false;
            // 
            // effectInputBox
            // 
            this.effectInputBox.BackColor = System.Drawing.Color.Transparent;
            this.effectInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.effectInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.effectInputBox.Image = null;
            this.effectInputBox.Location = new System.Drawing.Point(17, 152);
            this.effectInputBox.MaxLength = 32767;
            this.effectInputBox.Multiline = true;
            this.effectInputBox.Name = "effectInputBox";
            this.effectInputBox.ReadOnly = false;
            this.effectInputBox.Size = new System.Drawing.Size(234, 59);
            this.effectInputBox.TabIndex = 27;
            this.effectInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.effectInputBox.UseSystemPasswordChar = false;
            // 
            // tasteInputBox
            // 
            this.tasteInputBox.BackColor = System.Drawing.Color.Transparent;
            this.tasteInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tasteInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.tasteInputBox.Image = null;
            this.tasteInputBox.Location = new System.Drawing.Point(276, 152);
            this.tasteInputBox.MaxLength = 32767;
            this.tasteInputBox.Multiline = true;
            this.tasteInputBox.Name = "tasteInputBox";
            this.tasteInputBox.ReadOnly = false;
            this.tasteInputBox.Size = new System.Drawing.Size(234, 59);
            this.tasteInputBox.TabIndex = 28;
            this.tasteInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tasteInputBox.UseSystemPasswordChar = false;
            // 
            // negativesInputBox
            // 
            this.negativesInputBox.BackColor = System.Drawing.Color.Transparent;
            this.negativesInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.negativesInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.negativesInputBox.Image = null;
            this.negativesInputBox.Location = new System.Drawing.Point(17, 245);
            this.negativesInputBox.MaxLength = 32767;
            this.negativesInputBox.Multiline = true;
            this.negativesInputBox.Name = "negativesInputBox";
            this.negativesInputBox.ReadOnly = false;
            this.negativesInputBox.Size = new System.Drawing.Size(234, 59);
            this.negativesInputBox.TabIndex = 29;
            this.negativesInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.negativesInputBox.UseSystemPasswordChar = false;
            // 
            // thcInputBox
            // 
            this.thcInputBox.BackColor = System.Drawing.Color.Transparent;
            this.thcInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.thcInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.thcInputBox.Image = null;
            this.thcInputBox.Location = new System.Drawing.Point(199, 80);
            this.thcInputBox.MaxLength = 32767;
            this.thcInputBox.Multiline = false;
            this.thcInputBox.Name = "thcInputBox";
            this.thcInputBox.ReadOnly = false;
            this.thcInputBox.Size = new System.Drawing.Size(86, 41);
            this.thcInputBox.TabIndex = 30;
            this.thcInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.thcInputBox.UseSystemPasswordChar = false;
            // 
            // cbdInputBox
            // 
            this.cbdInputBox.BackColor = System.Drawing.Color.Transparent;
            this.cbdInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbdInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.cbdInputBox.Image = null;
            this.cbdInputBox.Location = new System.Drawing.Point(291, 82);
            this.cbdInputBox.MaxLength = 32767;
            this.cbdInputBox.Multiline = false;
            this.cbdInputBox.Name = "cbdInputBox";
            this.cbdInputBox.ReadOnly = false;
            this.cbdInputBox.Size = new System.Drawing.Size(86, 41);
            this.cbdInputBox.TabIndex = 31;
            this.cbdInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cbdInputBox.UseSystemPasswordChar = false;
            // 
            // ratingInputBox
            // 
            this.ratingInputBox.BackColor = System.Drawing.Color.Transparent;
            this.ratingInputBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ratingInputBox.ForeColor = System.Drawing.Color.DimGray;
            this.ratingInputBox.Image = null;
            this.ratingInputBox.Location = new System.Drawing.Point(383, 82);
            this.ratingInputBox.MaxLength = 32767;
            this.ratingInputBox.Multiline = false;
            this.ratingInputBox.Name = "ratingInputBox";
            this.ratingInputBox.ReadOnly = false;
            this.ratingInputBox.Size = new System.Drawing.Size(86, 41);
            this.ratingInputBox.TabIndex = 32;
            this.ratingInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ratingInputBox.UseSystemPasswordChar = false;
            // 
            // AddStrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 333);
            this.Controls.Add(this.ratingInputBox);
            this.Controls.Add(this.cbdInputBox);
            this.Controls.Add(this.thcInputBox);
            this.Controls.Add(this.negativesInputBox);
            this.Controls.Add(this.tasteInputBox);
            this.Controls.Add(this.effectInputBox);
            this.Controls.Add(this.strainNameInputBox);
            this.Controls.Add(this.bigLabel6);
            this.Controls.Add(this.strainComboBox);
            this.Controls.Add(this.bigLabel5);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.strainImageDisplay);
            this.Controls.Add(this.addStrainButton);
            this.Controls.Add(this.bigLabel4);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStrain";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strainImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.Panel headerPanel;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel usernameLabel;
        private ReaLTaiizor.Controls.BigLabel passwordLabel;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.AloneButton addStrainButton;
        private ReaLTaiizor.Controls.AloneButton addImageButton;
        private System.Windows.Forms.PictureBox strainImageDisplay;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ReaLTaiizor.Controls.AloneComboBox strainComboBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.ControlBox controlBox;
        private ReaLTaiizor.Controls.BigTextBox strainNameInputBox;
        private ReaLTaiizor.Controls.BigTextBox effectInputBox;
        private ReaLTaiizor.Controls.BigTextBox tasteInputBox;
        private ReaLTaiizor.Controls.BigTextBox negativesInputBox;
        private ReaLTaiizor.Controls.BigTextBox thcInputBox;
        private ReaLTaiizor.Controls.BigTextBox cbdInputBox;
        private ReaLTaiizor.Controls.BigTextBox ratingInputBox;
    }
}

