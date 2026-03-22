namespace WindowsFormsApp1
{
    partial class frmAggiornaUtente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAggiornaUtente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfermaPassNew = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtNameNew = new System.Windows.Forms.TextBox();
            this.lblConfermaPassNew = new System.Windows.Forms.Label();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.lblNameNew = new System.Windows.Forms.Label();
            this.btnAnnullaNew = new System.Windows.Forms.Button();
            this.btnSalvaNew = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 365);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 72);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Aggiorna i dati di accesso per questo programma";
            // 
            // txtConfermaPassNew
            // 
            this.txtConfermaPassNew.Location = new System.Drawing.Point(148, 200);
            this.txtConfermaPassNew.Name = "txtConfermaPassNew";
            this.txtConfermaPassNew.Size = new System.Drawing.Size(382, 22);
            this.txtConfermaPassNew.TabIndex = 31;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(148, 138);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(382, 22);
            this.txtPasswordNew.TabIndex = 30;
            // 
            // txtNameNew
            // 
            this.txtNameNew.Location = new System.Drawing.Point(148, 78);
            this.txtNameNew.Name = "txtNameNew";
            this.txtNameNew.Size = new System.Drawing.Size(382, 22);
            this.txtNameNew.TabIndex = 29;
            // 
            // lblConfermaPassNew
            // 
            this.lblConfermaPassNew.AutoSize = true;
            this.lblConfermaPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfermaPassNew.Location = new System.Drawing.Point(46, 182);
            this.lblConfermaPassNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfermaPassNew.Name = "lblConfermaPassNew";
            this.lblConfermaPassNew.Size = new System.Drawing.Size(96, 40);
            this.lblConfermaPassNew.TabIndex = 28;
            this.lblConfermaPassNew.Text = "Conferma \r\npassword:";
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNew.Location = new System.Drawing.Point(45, 138);
            this.lblPasswordNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(97, 20);
            this.lblPasswordNew.TabIndex = 27;
            this.lblPasswordNew.Text = "Password:";
            // 
            // lblNameNew
            // 
            this.lblNameNew.AutoSize = true;
            this.lblNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNew.Location = new System.Drawing.Point(78, 80);
            this.lblNameNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameNew.Name = "lblNameNew";
            this.lblNameNew.Size = new System.Drawing.Size(63, 20);
            this.lblNameNew.TabIndex = 26;
            this.lblNameNew.Text = "Nome:";
            // 
            // btnAnnullaNew
            // 
            this.btnAnnullaNew.BackColor = System.Drawing.Color.Red;
            this.btnAnnullaNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnullaNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaNew.Location = new System.Drawing.Point(559, 159);
            this.btnAnnullaNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnullaNew.Name = "btnAnnullaNew";
            this.btnAnnullaNew.Size = new System.Drawing.Size(179, 63);
            this.btnAnnullaNew.TabIndex = 33;
            this.btnAnnullaNew.Text = "Annulla";
            this.toolTip1.SetToolTip(this.btnAnnullaNew, "Annulla operazione - le modifiche non verranno salvate");
            this.btnAnnullaNew.UseVisualStyleBackColor = false;
            this.btnAnnullaNew.Click += new System.EventHandler(this.btnAnnullaNew_Click);
            // 
            // btnSalvaNew
            // 
            this.btnSalvaNew.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalvaNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvaNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaNew.Location = new System.Drawing.Point(559, 78);
            this.btnSalvaNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaNew.Name = "btnSalvaNew";
            this.btnSalvaNew.Size = new System.Drawing.Size(179, 63);
            this.btnSalvaNew.TabIndex = 32;
            this.btnSalvaNew.Text = "Salva modifiche";
            this.toolTip1.SetToolTip(this.btnSalvaNew, "Salva modifiche -  i nuovi dati di accesso saranno salvati");
            this.btnSalvaNew.UseVisualStyleBackColor = false;
            // 
            // frmAggiornaUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnullaNew);
            this.Controls.Add(this.btnSalvaNew);
            this.Controls.Add(this.txtConfermaPassNew);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtNameNew);
            this.Controls.Add(this.lblConfermaPassNew);
            this.Controls.Add(this.lblPasswordNew);
            this.Controls.Add(this.lblNameNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAggiornaUtente";
            this.Text = "Gestore password - Aggiorna dati di accesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfermaPassNew;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.Label lblConfermaPassNew;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.Label lblNameNew;
        private System.Windows.Forms.Button btnAnnullaNew;
        private System.Windows.Forms.Button btnSalvaNew;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}