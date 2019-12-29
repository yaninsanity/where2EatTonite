namespace Where2EatTonite
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRestaurantSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResturantAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateResturantUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.restaurantNumDisplayLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.restaurantInfoLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(417, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importIToolStripMenuItem,
            this.saveRestaurantSToolStripMenuItem,
            this.exitEToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "&File(F)";
            // 
            // importIToolStripMenuItem
            // 
            this.importIToolStripMenuItem.Name = "importIToolStripMenuItem";
            this.importIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importIToolStripMenuItem.Text = "&Import Restaurant(I)";
            this.importIToolStripMenuItem.Click += new System.EventHandler(this.importIToolStripMenuItem_Click);
            // 
            // saveRestaurantSToolStripMenuItem
            // 
            this.saveRestaurantSToolStripMenuItem.Name = "saveRestaurantSToolStripMenuItem";
            this.saveRestaurantSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveRestaurantSToolStripMenuItem.Text = "&Save Restaurant(S)";
            this.saveRestaurantSToolStripMenuItem.Click += new System.EventHandler(this.saveRestaurantSToolStripMenuItem_Click);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitEToolStripMenuItem.Text = "&Exit(E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResturantAToolStripMenuItem,
            this.updateResturantUToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.editEToolStripMenuItem.Text = "&Edit(E)";
            // 
            // addResturantAToolStripMenuItem
            // 
            this.addResturantAToolStripMenuItem.Name = "addResturantAToolStripMenuItem";
            this.addResturantAToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addResturantAToolStripMenuItem.Text = "&Add New Resturant(A)";
            this.addResturantAToolStripMenuItem.Click += new System.EventHandler(this.addResturantAToolStripMenuItem_Click);
            // 
            // updateResturantUToolStripMenuItem
            // 
            this.updateResturantUToolStripMenuItem.Name = "updateResturantUToolStripMenuItem";
            this.updateResturantUToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.updateResturantUToolStripMenuItem.Text = "&View and Update Resturant(V)";
            this.updateResturantUToolStripMenuItem.Click += new System.EventHandler(this.updateResturantUToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.aboutMeMToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "&Help(H)";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readMeToolStripMenuItem.Text = "&View Help(V)";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // aboutMeMToolStripMenuItem
            // 
            this.aboutMeMToolStripMenuItem.Name = "aboutMeMToolStripMenuItem";
            this.aboutMeMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMeMToolStripMenuItem.Text = "About &Me!(M)";
            this.aboutMeMToolStripMenuItem.Click += new System.EventHandler(this.aboutMeMToolStripMenuItem_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.Location = new System.Drawing.Point(17, 68);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(101, 43);
            this.randomButton.TabIndex = 1;
            this.randomButton.Text = "Random!";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 237);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(417, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Ready;";
            // 
            // restaurantNumDisplayLabel
            // 
            this.restaurantNumDisplayLabel.AutoSize = true;
            this.restaurantNumDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantNumDisplayLabel.Location = new System.Drawing.Point(12, 40);
            this.restaurantNumDisplayLabel.Name = "restaurantNumDisplayLabel";
            this.restaurantNumDisplayLabel.Size = new System.Drawing.Size(219, 25);
            this.restaurantNumDisplayLabel.TabIndex = 3;
            this.restaurantNumDisplayLabel.Text = "Number of Resturants: ";
            // 
            // restaurantInfoLabel
            // 
            this.restaurantInfoLabel.AutoSize = true;
            this.restaurantInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.restaurantInfoLabel.Location = new System.Drawing.Point(17, 129);
            this.restaurantInfoLabel.Name = "restaurantInfoLabel";
            this.restaurantInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.restaurantInfoLabel.TabIndex = 4;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.Red;
            this.copyrightLabel.Location = new System.Drawing.Point(12, 212);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(276, 16);
            this.copyrightLabel.TabIndex = 5;
            this.copyrightLabel.Text = "© 2019 https://jlblog.tech/ All Rights Reserved";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Where2EatTonite.Properties.Resources.donation;
            this.pictureBox.Location = new System.Drawing.Point(285, 117);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(132, 117);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 259);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.restaurantInfoLabel);
            this.Controls.Add(this.restaurantNumDisplayLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "main";
            this.Text = "Where 2 Eat Tonite?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRestaurantSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResturantAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateResturantUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeMToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label restaurantNumDisplayLabel;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label restaurantInfoLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

