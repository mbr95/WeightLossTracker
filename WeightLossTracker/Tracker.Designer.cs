﻿namespace WeightLossTracker
{
    partial class Tracker
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
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddWeightBtn = new System.Windows.Forms.Button();
            this.WeightValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetWeightButton = new System.Windows.Forms.Button();
            this.showWeightBox = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 24;
            this.UsersListBox.Location = new System.Drawing.Point(12, 12);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(165, 220);
            this.UsersListBox.TabIndex = 0;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(12, 378);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(165, 37);
            this.AddUserBtn.TabIndex = 1;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(12, 273);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(165, 29);
            this.FirstNameBox.TabIndex = 2;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(12, 341);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(165, 29);
            this.LastNameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // AddWeightBtn
            // 
            this.AddWeightBtn.Location = new System.Drawing.Point(220, 378);
            this.AddWeightBtn.Name = "AddWeightBtn";
            this.AddWeightBtn.Size = new System.Drawing.Size(160, 37);
            this.AddWeightBtn.TabIndex = 6;
            this.AddWeightBtn.Text = "Add Weight";
            this.AddWeightBtn.UseVisualStyleBackColor = true;
            this.AddWeightBtn.Click += new System.EventHandler(this.AddWeightBtn_Click);
            // 
            // WeightValueBox
            // 
            this.WeightValueBox.Location = new System.Drawing.Point(220, 341);
            this.WeightValueBox.Name = "WeightValueBox";
            this.WeightValueBox.Size = new System.Drawing.Size(160, 29);
            this.WeightValueBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight";
            // 
            // GetWeightButton
            // 
            this.GetWeightButton.Location = new System.Drawing.Point(493, 382);
            this.GetWeightButton.Name = "GetWeightButton";
            this.GetWeightButton.Size = new System.Drawing.Size(120, 33);
            this.GetWeightButton.TabIndex = 9;
            this.GetWeightButton.Text = "GetWeight";
            this.GetWeightButton.UseVisualStyleBackColor = true;
            this.GetWeightButton.Click += new System.EventHandler(this.GetWeightButton_Click);
            // 
            // showWeightBox
            // 
            this.showWeightBox.FormattingEnabled = true;
            this.showWeightBox.ItemHeight = 24;
            this.showWeightBox.Location = new System.Drawing.Point(493, 174);
            this.showWeightBox.Name = "showWeightBox";
            this.showWeightBox.Size = new System.Drawing.Size(200, 148);
            this.showWeightBox.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(493, 340);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 29);
            this.datePicker.TabIndex = 11;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 427);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.showWeightBox);
            this.Controls.Add(this.GetWeightButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightValueBox);
            this.Controls.Add(this.AddWeightBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UsersListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Tracker";
            this.Text = "Weight loss tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddWeightBtn;
        private System.Windows.Forms.TextBox WeightValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetWeightButton;
        private System.Windows.Forms.ListBox showWeightBox;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}

