namespace Where2EatTonite
{
    partial class viewRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewRestaurant));
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.restaurantSearchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.restaurantListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantLabel.Location = new System.Drawing.Point(22, 21);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(121, 25);
            this.restaurantLabel.TabIndex = 0;
            this.restaurantLabel.Text = "Restaurants:";
            // 
            // restaurantSearchTextbox
            // 
            this.restaurantSearchTextbox.Location = new System.Drawing.Point(149, 26);
            this.restaurantSearchTextbox.Name = "restaurantSearchTextbox";
            this.restaurantSearchTextbox.Size = new System.Drawing.Size(112, 20);
            this.restaurantSearchTextbox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(291, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshListButton.Location = new System.Drawing.Point(389, 22);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(93, 23);
            this.refreshListButton.TabIndex = 3;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // restaurantListBox
            // 
            this.restaurantListBox.FormattingEnabled = true;
            this.restaurantListBox.Location = new System.Drawing.Point(27, 61);
            this.restaurantListBox.Name = "restaurantListBox";
            this.restaurantListBox.Size = new System.Drawing.Size(455, 147);
            this.restaurantListBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(27, 232);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(93, 38);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(215, 232);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(93, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(389, 229);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 38);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 282);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.restaurantListBox);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.restaurantSearchTextbox);
            this.Controls.Add(this.restaurantLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewRestaurant";
            this.Text = " Where 2 Eat tonie ---- View & Search Restaurant";
            this.Load += new System.EventHandler(this.viewRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.TextBox restaurantSearchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.ListBox restaurantListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
    }
}