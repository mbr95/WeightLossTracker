namespace WeightLossTracker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateWeightBtn = new System.Windows.Forms.Button();
            this.WeightValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeleteWeightBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // UpdateWeightBtn
            // 
            this.UpdateWeightBtn.Location = new System.Drawing.Point(220, 314);
            this.UpdateWeightBtn.Name = "UpdateWeightBtn";
            this.UpdateWeightBtn.Size = new System.Drawing.Size(160, 37);
            this.UpdateWeightBtn.TabIndex = 6;
            this.UpdateWeightBtn.Text = "Update Weight";
            this.UpdateWeightBtn.UseVisualStyleBackColor = true;
            this.UpdateWeightBtn.Click += new System.EventHandler(this.UpdateWeightBtn_Click);
            // 
            // WeightValueBox
            // 
            this.WeightValueBox.Location = new System.Drawing.Point(220, 274);
            this.WeightValueBox.Name = "WeightValueBox";
            this.WeightValueBox.Size = new System.Drawing.Size(160, 29);
            this.WeightValueBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(442, 273);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 29);
            this.dateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(220, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(449, 220);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // DeleteWeightBtn
            // 
            this.DeleteWeightBtn.Location = new System.Drawing.Point(442, 314);
            this.DeleteWeightBtn.Name = "DeleteWeightBtn";
            this.DeleteWeightBtn.Size = new System.Drawing.Size(214, 37);
            this.DeleteWeightBtn.TabIndex = 12;
            this.DeleteWeightBtn.Text = "Delete Weight";
            this.DeleteWeightBtn.UseVisualStyleBackColor = true;
            this.DeleteWeightBtn.Click += new System.EventHandler(this.DeleteWeightBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(220, 378);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(160, 37);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Delete User";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 427);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.DeleteWeightBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightValueBox);
            this.Controls.Add(this.UpdateWeightBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button UpdateWeightBtn;
        private System.Windows.Forms.TextBox WeightValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button DeleteWeightBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
    }
}

