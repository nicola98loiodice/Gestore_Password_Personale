namespace WindowsFormsApp1
{
    partial class frmCreaCredenziali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreaCredenziali));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSito = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfermaPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Crea nuove credenziali";
            // 
            // lblSito
            // 
            this.lblSito.AutoSize = true;
            this.lblSito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSito.Location = new System.Drawing.Point(155, 95);
            this.lblSito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSito.Name = "lblSito";
            this.lblSito.Size = new System.Drawing.Size(48, 20);
            this.lblSito.TabIndex = 11;
            this.lblSito.Text = "Sito:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(143, 156);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(140, 213);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Nome:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(115, 271);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 20);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfermaPass
            // 
            this.lblConfermaPass.AutoSize = true;
            this.lblConfermaPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfermaPass.Location = new System.Drawing.Point(116, 315);
            this.lblConfermaPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfermaPass.Name = "lblConfermaPass";
            this.lblConfermaPass.Size = new System.Drawing.Size(96, 40);
            this.lblConfermaPass.TabIndex = 15;
            this.lblConfermaPass.Text = "Conferma \r\npassword:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 22);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(382, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(382, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(382, 22);
            this.textBox5.TabIndex = 20;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(218, 395);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(179, 63);
            this.btnSalva.TabIndex = 21;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Red;
            this.btnAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(417, 395);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(179, 63);
            this.btnAnnulla.TabIndex = 22;
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
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmCreaCredenziali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConfermaPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSito);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreaCredenziali";
            this.Text = "Gestore password - Crea nuove credenziali";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSito;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfermaPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}