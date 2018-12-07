namespace PeopleForm
{
    partial class Form1
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.FirstNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.LastNameInsLabel = new System.Windows.Forms.Label();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.EmailInsLabel = new System.Windows.Forms.Label();
            this.stateInsText = new System.Windows.Forms.TextBox();
            this.StateInsLabel = new System.Windows.Forms.Label();
            this.cityInsText = new System.Windows.Forms.TextBox();
            this.CityInsLabel = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.PhoneInsLabel = new System.Windows.Forms.Label();
            this.zipInsText = new System.Windows.Forms.TextBox();
            this.ZipInsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(32, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for Customers:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(198, 94);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(245, 38);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 31;
            this.searchListBox.Location = new System.Drawing.Point(38, 253);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(1445, 190);
            this.searchListBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(198, 161);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 62);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert A Customer:";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(198, 583);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(245, 38);
            this.firstNameInsText.TabIndex = 7;
            // 
            // FirstNameInsLabel
            // 
            this.FirstNameInsLabel.AutoSize = true;
            this.FirstNameInsLabel.Location = new System.Drawing.Point(32, 589);
            this.FirstNameInsLabel.Name = "FirstNameInsLabel";
            this.FirstNameInsLabel.Size = new System.Drawing.Size(160, 32);
            this.FirstNameInsLabel.TabIndex = 6;
            this.FirstNameInsLabel.Text = "First Name:";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(198, 638);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(245, 38);
            this.lastNameInsText.TabIndex = 9;
            // 
            // LastNameInsLabel
            // 
            this.LastNameInsLabel.AutoSize = true;
            this.LastNameInsLabel.Location = new System.Drawing.Point(32, 644);
            this.LastNameInsLabel.Name = "LastNameInsLabel";
            this.LastNameInsLabel.Size = new System.Drawing.Size(159, 32);
            this.LastNameInsLabel.TabIndex = 8;
            this.LastNameInsLabel.Text = "Last Name:";
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(198, 691);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(245, 38);
            this.emailInsText.TabIndex = 11;
            // 
            // EmailInsLabel
            // 
            this.EmailInsLabel.AutoSize = true;
            this.EmailInsLabel.Location = new System.Drawing.Point(32, 697);
            this.EmailInsLabel.Name = "EmailInsLabel";
            this.EmailInsLabel.Size = new System.Drawing.Size(95, 32);
            this.EmailInsLabel.TabIndex = 10;
            this.EmailInsLabel.Text = "Email:";
            // 
            // stateInsText
            // 
            this.stateInsText.Location = new System.Drawing.Point(198, 855);
            this.stateInsText.Name = "stateInsText";
            this.stateInsText.Size = new System.Drawing.Size(245, 38);
            this.stateInsText.TabIndex = 17;
            // 
            // StateInsLabel
            // 
            this.StateInsLabel.AutoSize = true;
            this.StateInsLabel.Location = new System.Drawing.Point(32, 861);
            this.StateInsLabel.Name = "StateInsLabel";
            this.StateInsLabel.Size = new System.Drawing.Size(90, 32);
            this.StateInsLabel.TabIndex = 16;
            this.StateInsLabel.Text = "State:";
            // 
            // cityInsText
            // 
            this.cityInsText.Location = new System.Drawing.Point(198, 801);
            this.cityInsText.Name = "cityInsText";
            this.cityInsText.Size = new System.Drawing.Size(245, 38);
            this.cityInsText.TabIndex = 15;
            // 
            // CityInsLabel
            // 
            this.CityInsLabel.AutoSize = true;
            this.CityInsLabel.Location = new System.Drawing.Point(32, 807);
            this.CityInsLabel.Name = "CityInsLabel";
            this.CityInsLabel.Size = new System.Drawing.Size(72, 32);
            this.CityInsLabel.TabIndex = 14;
            this.CityInsLabel.Text = "City:";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(198, 747);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(245, 38);
            this.phoneInsText.TabIndex = 13;
            // 
            // PhoneInsLabel
            // 
            this.PhoneInsLabel.AutoSize = true;
            this.PhoneInsLabel.Location = new System.Drawing.Point(32, 753);
            this.PhoneInsLabel.Name = "PhoneInsLabel";
            this.PhoneInsLabel.Size = new System.Drawing.Size(106, 32);
            this.PhoneInsLabel.TabIndex = 12;
            this.PhoneInsLabel.Text = "Phone:";
            // 
            // zipInsText
            // 
            this.zipInsText.Location = new System.Drawing.Point(198, 911);
            this.zipInsText.Name = "zipInsText";
            this.zipInsText.Size = new System.Drawing.Size(245, 38);
            this.zipInsText.TabIndex = 19;
            // 
            // ZipInsLabel
            // 
            this.ZipInsLabel.AutoSize = true;
            this.ZipInsLabel.Location = new System.Drawing.Point(32, 917);
            this.ZipInsLabel.Name = "ZipInsLabel";
            this.ZipInsLabel.Size = new System.Drawing.Size(63, 32);
            this.ZipInsLabel.TabIndex = 18;
            this.ZipInsLabel.Text = "Zip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1635, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(198, 975);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(209, 65);
            this.insertButton.TabIndex = 22;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1072);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zipInsText);
            this.Controls.Add(this.ZipInsLabel);
            this.Controls.Add(this.stateInsText);
            this.Controls.Add(this.StateInsLabel);
            this.Controls.Add(this.cityInsText);
            this.Controls.Add(this.CityInsLabel);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.PhoneInsLabel);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.EmailInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.LastNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.FirstNameInsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "Form1";
            this.Text = "SQL Server Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label FirstNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label LastNameInsLabel;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Label EmailInsLabel;
        private System.Windows.Forms.TextBox stateInsText;
        private System.Windows.Forms.Label StateInsLabel;
        private System.Windows.Forms.TextBox cityInsText;
        private System.Windows.Forms.Label CityInsLabel;
        private System.Windows.Forms.TextBox phoneInsText;
        private System.Windows.Forms.Label PhoneInsLabel;
        private System.Windows.Forms.TextBox zipInsText;
        private System.Windows.Forms.Label ZipInsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertButton;
    }
}

