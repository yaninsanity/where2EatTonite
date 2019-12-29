namespace Where2EatTonite
{
    partial class addRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addRestaurant));
            this.restaurantNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.restaurantTypeLabel = new System.Windows.Forms.Label();
            this.restaurantTypeComboBox = new System.Windows.Forms.ComboBox();
            this.preferenceLabel = new System.Windows.Forms.Label();
            this.preference1RadioButton = new System.Windows.Forms.RadioButton();
            this.preference2RadioButton = new System.Windows.Forms.RadioButton();
            this.preference3RadioButton = new System.Windows.Forms.RadioButton();
            this.preference4RadioButton = new System.Windows.Forms.RadioButton();
            this.preference5RadioButton = new System.Windows.Forms.RadioButton();
            this.addressLabel = new System.Windows.Forms.Label();
            this.restaurantAddressTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantNameTextBox
            // 
            resources.ApplyResources(this.restaurantNameTextBox, "restaurantNameTextBox");
            this.restaurantNameTextBox.Name = "restaurantNameTextBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // restaurantTypeLabel
            // 
            resources.ApplyResources(this.restaurantTypeLabel, "restaurantTypeLabel");
            this.restaurantTypeLabel.Name = "restaurantTypeLabel";
            // 
            // restaurantTypeComboBox
            // 
            this.restaurantTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurantTypeComboBox.FormattingEnabled = true;
            this.restaurantTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("restaurantTypeComboBox.Items"),
            resources.GetString("restaurantTypeComboBox.Items1"),
            resources.GetString("restaurantTypeComboBox.Items2"),
            resources.GetString("restaurantTypeComboBox.Items3"),
            resources.GetString("restaurantTypeComboBox.Items4"),
            resources.GetString("restaurantTypeComboBox.Items5")});
            resources.ApplyResources(this.restaurantTypeComboBox, "restaurantTypeComboBox");
            this.restaurantTypeComboBox.Name = "restaurantTypeComboBox";
            // 
            // preferenceLabel
            // 
            resources.ApplyResources(this.preferenceLabel, "preferenceLabel");
            this.preferenceLabel.Name = "preferenceLabel";
            this.preferenceLabel.Click += new System.EventHandler(this.preferenceLabel_Click);
            // 
            // preference1RadioButton
            // 
            resources.ApplyResources(this.preference1RadioButton, "preference1RadioButton");
            this.preference1RadioButton.Name = "preference1RadioButton";
            this.preference1RadioButton.TabStop = true;
            this.preference1RadioButton.UseVisualStyleBackColor = true;
            // 
            // preference2RadioButton
            // 
            resources.ApplyResources(this.preference2RadioButton, "preference2RadioButton");
            this.preference2RadioButton.Name = "preference2RadioButton";
            this.preference2RadioButton.TabStop = true;
            this.preference2RadioButton.UseVisualStyleBackColor = true;
            // 
            // preference3RadioButton
            // 
            resources.ApplyResources(this.preference3RadioButton, "preference3RadioButton");
            this.preference3RadioButton.Name = "preference3RadioButton";
            this.preference3RadioButton.TabStop = true;
            this.preference3RadioButton.UseVisualStyleBackColor = true;
            // 
            // preference4RadioButton
            // 
            resources.ApplyResources(this.preference4RadioButton, "preference4RadioButton");
            this.preference4RadioButton.Name = "preference4RadioButton";
            this.preference4RadioButton.TabStop = true;
            this.preference4RadioButton.UseVisualStyleBackColor = true;
            // 
            // preference5RadioButton
            // 
            resources.ApplyResources(this.preference5RadioButton, "preference5RadioButton");
            this.preference5RadioButton.Name = "preference5RadioButton";
            this.preference5RadioButton.TabStop = true;
            this.preference5RadioButton.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // restaurantAddressTextBox
            // 
            resources.ApplyResources(this.restaurantAddressTextBox, "restaurantAddressTextBox");
            this.restaurantAddressTextBox.Name = "restaurantAddressTextBox";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addRestaurant
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.restaurantAddressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.preference5RadioButton);
            this.Controls.Add(this.preference4RadioButton);
            this.Controls.Add(this.preference3RadioButton);
            this.Controls.Add(this.preference2RadioButton);
            this.Controls.Add(this.preference1RadioButton);
            this.Controls.Add(this.preferenceLabel);
            this.Controls.Add(this.restaurantTypeComboBox);
            this.Controls.Add(this.restaurantTypeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.restaurantNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addRestaurant";
            this.Load += new System.EventHandler(this.addRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox restaurantNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label restaurantTypeLabel;
        private System.Windows.Forms.ComboBox restaurantTypeComboBox;
        private System.Windows.Forms.Label preferenceLabel;
        private System.Windows.Forms.RadioButton preference1RadioButton;
        private System.Windows.Forms.RadioButton preference2RadioButton;
        private System.Windows.Forms.RadioButton preference3RadioButton;
        private System.Windows.Forms.RadioButton preference4RadioButton;
        private System.Windows.Forms.RadioButton preference5RadioButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox restaurantAddressTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button saveButton;
    }
}