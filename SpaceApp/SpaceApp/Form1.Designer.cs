namespace SpaceApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAcceder = new System.Windows.Forms.Button();
            this.txUsu = new System.Windows.Forms.TextBox();
            this.txContra = new System.Windows.Forms.TextBox();
            this.lbPs = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAcceder
            // 
            this.btAcceder.Location = new System.Drawing.Point(239, 218);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(157, 51);
            this.btAcceder.TabIndex = 9;
            this.btAcceder.Text = "Entrar";
            this.btAcceder.UseVisualStyleBackColor = true;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // txUsu
            // 
            this.txUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsu.Location = new System.Drawing.Point(239, 110);
            this.txUsu.Name = "txUsu";
            this.txUsu.Size = new System.Drawing.Size(157, 34);
            this.txUsu.TabIndex = 8;
            // 
            // txContra
            // 
            this.txContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txContra.Location = new System.Drawing.Point(239, 172);
            this.txContra.Name = "txContra";
            this.txContra.PasswordChar = '*';
            this.txContra.Size = new System.Drawing.Size(157, 34);
            this.txContra.TabIndex = 7;
            // 
            // lbPs
            // 
            this.lbPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPs.Location = new System.Drawing.Point(92, 168);
            this.lbPs.Name = "lbPs";
            this.lbPs.Size = new System.Drawing.Size(126, 30);
            this.lbPs.TabIndex = 6;
            this.lbPs.Text = "Password: ";
            this.lbPs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsu
            // 
            this.lbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsu.Location = new System.Drawing.Point(90, 106);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(128, 30);
            this.lbUsu.TabIndex = 5;
            this.lbUsu.Text = "User: ";
            this.lbUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.txUsu);
            this.Controls.Add(this.txContra);
            this.Controls.Add(this.lbPs);
            this.Controls.Add(this.lbUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.TextBox txUsu;
        private System.Windows.Forms.TextBox txContra;
        private System.Windows.Forms.Label lbPs;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.Label label1;
    }
}

