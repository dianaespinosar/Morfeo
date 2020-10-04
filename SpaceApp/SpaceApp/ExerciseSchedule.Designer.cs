namespace SpaceApp
{
    partial class ExerciseSchedule
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
            this.dgEx = new System.Windows.Forms.DataGridView();
            this.lbES = new System.Windows.Forms.Label();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgEx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEx
            // 
            this.dgEx.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEx.Location = new System.Drawing.Point(17, 64);
            this.dgEx.Name = "dgEx";
            this.dgEx.RowHeadersWidth = 51;
            this.dgEx.RowTemplate.Height = 24;
            this.dgEx.Size = new System.Drawing.Size(744, 261);
            this.dgEx.TabIndex = 0;
            // 
            // lbES
            // 
            this.lbES.AutoSize = true;
            this.lbES.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbES.Location = new System.Drawing.Point(12, 9);
            this.lbES.Name = "lbES";
            this.lbES.Size = new System.Drawing.Size(254, 29);
            this.lbES.TabIndex = 1;
            this.lbES.Text = "Exercise Schedule for ";
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(272, 16);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(200, 22);
            this.dtDay.TabIndex = 2;
            this.dtDay.ValueChanged += new System.EventHandler(this.dtDay_ValueChanged);
            // 
            // ExerciseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(782, 360);
            this.Controls.Add(this.dtDay);
            this.Controls.Add(this.lbES);
            this.Controls.Add(this.dgEx);
            this.Name = "ExerciseSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExerciseSchedule";
            this.Load += new System.EventHandler(this.ExerciseSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEx;
        private System.Windows.Forms.Label lbES;
        private System.Windows.Forms.DateTimePicker dtDay;
    }
}