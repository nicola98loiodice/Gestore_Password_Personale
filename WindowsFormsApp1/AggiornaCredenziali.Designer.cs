namespace WindowsFormsApp1
{
    partial class frmAggiorna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAggiorna));
            this.lblAggiorna = new System.Windows.Forms.Label();
            this.lblSitoSelezionato = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAggiorna
            // 
            this.lblAggiorna.AutoSize = true;
            this.lblAggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiorna.Location = new System.Drawing.Point(16, 9);
            this.lblAggiorna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAggiorna.Name = "lblAggiorna";
            this.lblAggiorna.Size = new System.Drawing.Size(547, 36);
            this.lblAggiorna.TabIndex = 10;
            this.lblAggiorna.Text = "Inserisci qui le modifiche che vuoi apportare alle credenziali selezionate\r\n\r\n";
            // 
            // lblSitoSelezionato
            // 
            this.lblSitoSelezionato.AutoSize = true;
            this.lblSitoSelezionato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitoSelezionato.Location = new System.Drawing.Point(16, 84);
            this.lblSitoSelezionato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSitoSelezionato.Name = "lblSitoSelezionato";
            this.lblSitoSelezionato.Size = new System.Drawing.Size(120, 16);
            this.lblSitoSelezionato.TabIndex = 11;
            this.lblSitoSelezionato.Text = "Sito Selezionato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(504, 22);
            this.textBox1.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(107, 142);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(107, 188);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nome:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(71, 233);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailUpdate.Location = new System.Drawing.Point(184, 142);
            this.txtEmailUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(368, 22);
            this.txtEmailUpdate.TabIndex = 17;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUpdate.Location = new System.Drawing.Point(184, 188);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(368, 22);
            this.txtNameUpdate.TabIndex = 18;
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordUpdate.Location = new System.Drawing.Point(184, 233);
            this.txtPasswordUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(368, 22);
            this.txtPasswordUpdate.TabIndex = 19;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(593, 122);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(179, 63);
            this.btnSalva.TabIndex = 20;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Red;
            this.btnAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(593, 193);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(179, 63);
            this.btnAnnulla.TabIndex = 21;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 445);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 96);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmAggiorna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtPasswordUpdate);
            this.Controls.Add(this.txtNameUpdate);
            this.Controls.Add(this.txtEmailUpdate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSitoSelezionato);
            this.Controls.Add(this.lblAggiorna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAggiorna";
            this.Text = "Aggiorna Credenziali";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAggiorna;
        private System.Windows.Forms.Label lblSitoSelezionato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}