namespace CST_150_Lucky_Number.PresentationLayer
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuckyNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(388, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucky Number";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(604, 255);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(242, 40);
            this.cmbYear.TabIndex = 1;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Items.AddRange(new object[] {
            "Yes:3",
            "No..."});
            this.cmbDate.Location = new System.Drawing.Point(604, 536);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(242, 40);
            this.cmbDate.TabIndex = 2;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "Dark Red",
            "Maroon",
            "Pink",
            "Baby Pink",
            "Neon Pink",
            "Orange",
            "Yellow",
            "Neon Yellow",
            "Green",
            "Sage Green",
            "Olive Green",
            "Forest Green",
            "Pastel Green",
            "Dark Green",
            "Neon Green",
            "Blue",
            "Sky Blue",
            "Baby Blue",
            "Navy",
            "Dark Blue",
            "Pastel Blue",
            "Purple",
            "Violet",
            "Pastel Purple",
            "Dark Purple",
            "Beige",
            "Khaki",
            "Brown",
            "Coffee Brown",
            "Peach",
            "White",
            "Black",
            "Grey"});
            this.cmbColor.Location = new System.Drawing.Point(604, 465);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(242, 40);
            this.cmbColor.TabIndex = 3;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(604, 396);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(242, 40);
            this.cmbDay.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(604, 327);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(242, 40);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.DropDown += new System.EventHandler(this.PopulateDays_DropDownClosedEventHandler);
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.PopulateDays_DropDownClosedEventHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(348, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Year: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(348, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birth Month: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(348, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth Day: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(348, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "Favorite Color: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(348, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 47);
            this.label6.TabIndex = 10;
            this.label6.Text = "Have a Date...? ";
            // 
            // btnLuckyNumber
            // 
            this.btnLuckyNumber.AutoSize = true;
            this.btnLuckyNumber.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLuckyNumber.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnLuckyNumber.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLuckyNumber.Location = new System.Drawing.Point(348, 634);
            this.btnLuckyNumber.Name = "btnLuckyNumber";
            this.btnLuckyNumber.Size = new System.Drawing.Size(498, 91);
            this.btnLuckyNumber.TabIndex = 11;
            this.btnLuckyNumber.Text = "What is my Lucky Nnumber?";
            this.btnLuckyNumber.UseVisualStyleBackColor = false;
            this.btnLuckyNumber.Click += new System.EventHandler(this.GetLuckyNumber_ClickEventHandler);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1187, 843);
            this.Controls.Add(this.btnLuckyNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.PopulateYear_LoadEventHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbYear;
        private ComboBox cmbDate;
        private ComboBox cmbColor;
        private ComboBox cmbDay;
        private ComboBox cmbMonth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnLuckyNumber;
    }
}