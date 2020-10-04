namespace SpaceApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addSleepingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tripInformationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.eastMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.westMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbM = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileMenu,
            this.mealsMenu,
            this.sleepMenu,
            this.exerciseMenu,
            this.tripInformationMenu,
            this.logOutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileMenu
            // 
            this.profileMenu.Name = "profileMenu";
            this.profileMenu.Size = new System.Drawing.Size(66, 26);
            this.profileMenu.Text = "Profile";
            this.profileMenu.Click += new System.EventHandler(this.profileMenu_Click);
            // 
            // mealsMenu
            // 
            this.mealsMenu.Name = "mealsMenu";
            this.mealsMenu.Size = new System.Drawing.Size(62, 26);
            this.mealsMenu.Text = "Meals";
            this.mealsMenu.Click += new System.EventHandler(this.mealsMenu_Click);
            // 
            // sleepMenu
            // 
            this.sleepMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSleepingInformationToolStripMenuItem,
            this.napToolStripMenuItem});
            this.sleepMenu.Name = "sleepMenu";
            this.sleepMenu.Size = new System.Drawing.Size(60, 26);
            this.sleepMenu.Text = "Sleep";
            // 
            // addSleepingInformationToolStripMenuItem
            // 
            this.addSleepingInformationToolStripMenuItem.Name = "addSleepingInformationToolStripMenuItem";
            this.addSleepingInformationToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.addSleepingInformationToolStripMenuItem.Text = "Add Sleeping Information";
            this.addSleepingInformationToolStripMenuItem.Click += new System.EventHandler(this.addSleepingInformationToolStripMenuItem_Click);
            // 
            // napToolStripMenuItem
            // 
            this.napToolStripMenuItem.Name = "napToolStripMenuItem";
            this.napToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.napToolStripMenuItem.Text = "Nap";
            this.napToolStripMenuItem.Click += new System.EventHandler(this.napToolStripMenuItem_Click);
            // 
            // exerciseMenu
            // 
            this.exerciseMenu.Name = "exerciseMenu";
            this.exerciseMenu.Size = new System.Drawing.Size(76, 26);
            this.exerciseMenu.Text = "Exercise";
            this.exerciseMenu.Click += new System.EventHandler(this.exerciseMenu_Click);
            // 
            // tripInformationMenu
            // 
            this.tripInformationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eastMenuItem,
            this.westMenuItem});
            this.tripInformationMenu.Name = "tripInformationMenu";
            this.tripInformationMenu.Size = new System.Drawing.Size(130, 26);
            this.tripInformationMenu.Text = "Trip Information";
            // 
            // logOutMenu
            // 
            this.logOutMenu.Name = "logOutMenu";
            this.logOutMenu.Size = new System.Drawing.Size(76, 26);
            this.logOutMenu.Text = "Log Out";
            this.logOutMenu.Click += new System.EventHandler(this.logOutMenu_Click);
            // 
            // eastMenuItem
            // 
            this.eastMenuItem.Name = "eastMenuItem";
            this.eastMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eastMenuItem.Text = "East";
            this.eastMenuItem.Click += new System.EventHandler(this.eastMenuItem_Click);
            // 
            // westMenuItem
            // 
            this.westMenuItem.Name = "westMenuItem";
            this.westMenuItem.Size = new System.Drawing.Size(224, 26);
            this.westMenuItem.Text = "West";
            this.westMenuItem.Click += new System.EventHandler(this.westMenuItem_Click);
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.BackColor = System.Drawing.Color.Transparent;
            this.lbM.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.ForeColor = System.Drawing.SystemColors.Info;
            this.lbM.Location = new System.Drawing.Point(12, 41);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(353, 73);
            this.lbM.TabIndex = 1;
            this.lbM.Text = "MORFEO";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 375);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileMenu;
        private System.Windows.Forms.ToolStripMenuItem mealsMenu;
        private System.Windows.Forms.ToolStripMenuItem sleepMenu;
        private System.Windows.Forms.ToolStripMenuItem exerciseMenu;
        private System.Windows.Forms.ToolStripMenuItem tripInformationMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutMenu;
        private System.Windows.Forms.ToolStripMenuItem napToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSleepingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eastMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westMenuItem;
        private System.Windows.Forms.Label lbM;
    }
}