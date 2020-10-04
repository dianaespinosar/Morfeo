namespace SpaceApp
{
    partial class Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
            this.lbFood = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cbBLD = new System.Windows.Forms.ComboBox();
            this.lbMeal = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txHour = new System.Windows.Forms.TextBox();
            this.txMinute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Location = new System.Drawing.Point(21, 15);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(48, 17);
            this.lbFood.TabIndex = 0;
            this.lbFood.Text = "Food: ";
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(85, 12);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 24);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Day: ";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(287, 15);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(299, 22);
            this.dtpTime.TabIndex = 3;
            // 
            // cbBLD
            // 
            this.cbBLD.FormattingEnabled = true;
            this.cbBLD.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.cbBLD.Location = new System.Drawing.Point(125, 79);
            this.cbBLD.Name = "cbBLD";
            this.cbBLD.Size = new System.Drawing.Size(119, 24);
            this.cbBLD.TabIndex = 4;
            // 
            // lbMeal
            // 
            this.lbMeal.AutoSize = true;
            this.lbMeal.Location = new System.Drawing.Point(21, 83);
            this.lbMeal.Name = "lbMeal";
            this.lbMeal.Size = new System.Drawing.Size(98, 17);
            this.lbMeal.TabIndex = 5;
            this.lbMeal.Text = "Type of meal: ";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAdd.Location = new System.Drawing.Point(467, 129);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 35);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minute:";
            // 
            // txHour
            // 
            this.txHour.Location = new System.Drawing.Point(315, 79);
            this.txHour.Name = "txHour";
            this.txHour.Size = new System.Drawing.Size(72, 22);
            this.txHour.TabIndex = 9;
            // 
            // txMinute
            // 
            this.txMinute.Location = new System.Drawing.Point(486, 79);
            this.txMinute.Name = "txMinute";
            this.txMinute.Size = new System.Drawing.Size(100, 22);
            this.txMinute.TabIndex = 10;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(608, 191);
            this.Controls.Add(this.txMinute);
            this.Controls.Add(this.txHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbMeal);
            this.Controls.Add(this.cbBLD);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.lbFood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal";
            this.Load += new System.EventHandler(this.Meal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cbBLD;
        private System.Windows.Forms.Label lbMeal;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txHour;
        private System.Windows.Forms.TextBox txMinute;
    }
}