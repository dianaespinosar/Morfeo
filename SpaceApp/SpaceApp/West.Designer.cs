namespace SpaceApp
{
    partial class West
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(West));
            this.lbWest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWest
            // 
            this.lbWest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWest.Image = ((System.Drawing.Image)(resources.GetObject("lbWest.Image")));
            this.lbWest.Location = new System.Drawing.Point(12, 25);
            this.lbWest.Name = "lbWest";
            this.lbWest.Size = new System.Drawing.Size(662, 274);
            this.lbWest.TabIndex = 1;
            // 
            // West
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(686, 338);
            this.Controls.Add(this.lbWest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "West";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "West";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWest;
    }
}