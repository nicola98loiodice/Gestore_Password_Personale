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
            this.SuspendLayout();
            // 
            // lblAggiorna
            // 
            this.lblAggiorna.AutoSize = true;
            this.lblAggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiorna.Location = new System.Drawing.Point(130, 9);
            this.lblAggiorna.Name = "lblAggiorna";
            this.lblAggiorna.Size = new System.Drawing.Size(547, 36);
            this.lblAggiorna.TabIndex = 10;
            this.lblAggiorna.Text = "Inserisci qui le modifiche che vuoi apportare alle credenziali selezionate\r\n\r\n";
            // 
            // lblSitoSelezionato
            // 
            this.lblSitoSelezionato.AutoSize = true;
            this.lblSitoSelezionato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitoSelezionato.Location = new System.Drawing.Point(12, 68);
            this.lblSitoSelezionato.Name = "lblSitoSelezionato";
            this.lblSitoSelezionato.Size = new System.Drawing.Size(120, 16);
            this.lblSitoSelezionato.TabIndex = 11;
            this.lblSitoSelezionato.Text = "Sito Selezionato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(80, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(80, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nome:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(53, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailUpdate.Location = new System.Drawing.Point(138, 115);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(277, 20);
            this.txtEmailUpdate.TabIndex = 17;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUpdate.Location = new System.Drawing.Point(138, 153);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(277, 20);
            this.txtNameUpdate.TabIndex = 18;
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordUpdate.Location = new System.Drawing.Point(138, 189);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(277, 20);
            this.txtPasswordUpdate.TabIndex = 19;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(446, 136);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(134, 51);
            this.btnSalva.TabIndex = 20;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            // 
            // frmAggiorna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 253);
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
            this.Name = "frmAggiorna";
            this.Text = "Aggiorna Credenziali";
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
    }
}