namespace WindowsFormsApp1
{
    partial class frmCreaUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreaUtente));
            this.txtPasswordProfilo = new System.Windows.Forms.TextBox();
            this.txtNameProfilo = new System.Windows.Forms.TextBox();
            this.lblPasswordProfilo = new System.Windows.Forms.Label();
            this.lblNameProfilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnnullaProfilo = new System.Windows.Forms.Button();
            this.btnSalvaProfilo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswordProfilo
            // 
            this.txtPasswordProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordProfilo.Location = new System.Drawing.Point(160, 130);
            this.txtPasswordProfilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordProfilo.Name = "txtPasswordProfilo";
            this.txtPasswordProfilo.PasswordChar = '*';
            this.txtPasswordProfilo.Size = new System.Drawing.Size(378, 29);
            this.txtPasswordProfilo.TabIndex = 8;
            // 
            // txtNameProfilo
            // 
            this.txtNameProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProfilo.Location = new System.Drawing.Point(160, 62);
            this.txtNameProfilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameProfilo.Name = "txtNameProfilo";
            this.txtNameProfilo.Size = new System.Drawing.Size(378, 29);
            this.txtNameProfilo.TabIndex = 7;
            // 
            // lblPasswordProfilo
            // 
            this.lblPasswordProfilo.AutoSize = true;
            this.lblPasswordProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordProfilo.Location = new System.Drawing.Point(33, 133);
            this.lblPasswordProfilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordProfilo.Name = "lblPasswordProfilo";
            this.lblPasswordProfilo.Size = new System.Drawing.Size(106, 24);
            this.lblPasswordProfilo.TabIndex = 6;
            this.lblPasswordProfilo.Text = "Password:";
            // 
            // lblNameProfilo
            // 
            this.lblNameProfilo.AutoSize = true;
            this.lblNameProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfilo.Location = new System.Drawing.Point(73, 64);
            this.lblNameProfilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameProfilo.Name = "lblNameProfilo";
            this.lblNameProfilo.Size = new System.Drawing.Size(72, 24);
            this.lblNameProfilo.TabIndex = 5;
            this.lblNameProfilo.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Crea il tuo profilo e la tua libreria di credenziali\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 348);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 89);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnnullaProfilo
            // 
            this.btnAnnullaProfilo.BackColor = System.Drawing.Color.Red;
            this.btnAnnullaProfilo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnullaProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaProfilo.Location = new System.Drawing.Point(359, 209);
            this.btnAnnullaProfilo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnullaProfilo.Name = "btnAnnullaProfilo";
            this.btnAnnullaProfilo.Size = new System.Drawing.Size(179, 63);
            this.btnAnnullaProfilo.TabIndex = 24;
            this.btnAnnullaProfilo.Text = "Annulla";
            this.btnAnnullaProfilo.UseVisualStyleBackColor = false;
            // 
            // btnSalvaProfilo
            // 
            this.btnSalvaProfilo.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalvaProfilo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvaProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaProfilo.Location = new System.Drawing.Point(160, 209);
            this.btnSalvaProfilo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaProfilo.Name = "btnSalvaProfilo";
            this.btnSalvaProfilo.Size = new System.Drawing.Size(179, 63);
            this.btnSalvaProfilo.TabIndex = 23;
            this.btnSalvaProfilo.Text = "Salva";
            this.btnSalvaProfilo.UseVisualStyleBackColor = false;
            // 
            // frmCreaUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnullaProfilo);
            this.Controls.Add(this.btnSalvaProfilo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordProfilo);
            this.Controls.Add(this.txtNameProfilo);
            this.Controls.Add(this.lblPasswordProfilo);
            this.Controls.Add(this.lblNameProfilo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreaUtente";
            this.Text = "Gestore Password - Crea Utente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordProfilo;
        private System.Windows.Forms.TextBox txtNameProfilo;
        private System.Windows.Forms.Label lblPasswordProfilo;
        private System.Windows.Forms.Label lblNameProfilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnullaProfilo;
        private System.Windows.Forms.Button btnSalvaProfilo;
    }
}