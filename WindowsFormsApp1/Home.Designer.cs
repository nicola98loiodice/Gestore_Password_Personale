namespace WindowsFormsApp1
{
    partial class frmCerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerca));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCerca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVisualizzaElenco = new System.Windows.Forms.Button();
            this.btnCreaNuovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 445);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 96);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cerca il sito o la pagina a cui sei iscritto dal menù a tendina \r\ne ti verranno m" +
    "ostrate le tue credenziali.\r\n";
            // 
            // lblCerca
            // 
            this.lblCerca.AutoSize = true;
            this.lblCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerca.Location = new System.Drawing.Point(35, 134);
            this.lblCerca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerca.Name = "lblCerca";
            this.lblCerca.Size = new System.Drawing.Size(48, 16);
            this.lblCerca.TabIndex = 10;
            this.lblCerca.Text = "Cerca";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 134);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 250);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(33, 192);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(4, 306);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 16);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Location = new System.Drawing.Point(115, 187);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(368, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(115, 245);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(368, 22);
            this.txtName.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(115, 300);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(368, 22);
            this.txtPassword.TabIndex = 17;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAggiorna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiorna.Image = ((System.Drawing.Image)(resources.GetObject("btnAggiorna.Image")));
            this.btnAggiorna.Location = new System.Drawing.Point(509, 132);
            this.btnAggiorna.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(100, 100);
            this.btnAggiorna.TabIndex = 18;
            this.btnAggiorna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggiorna.UseVisualStyleBackColor = false;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(509, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVisualizzaElenco
            // 
            this.btnVisualizzaElenco.BackColor = System.Drawing.Color.Gold;
            this.btnVisualizzaElenco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizzaElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaElenco.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizzaElenco.Image")));
            this.btnVisualizzaElenco.Location = new System.Drawing.Point(655, 239);
            this.btnVisualizzaElenco.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizzaElenco.Name = "btnVisualizzaElenco";
            this.btnVisualizzaElenco.Size = new System.Drawing.Size(100, 100);
            this.btnVisualizzaElenco.TabIndex = 20;
            this.btnVisualizzaElenco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizzaElenco.UseVisualStyleBackColor = false;
            // 
            // btnCreaNuovo
            // 
            this.btnCreaNuovo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreaNuovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreaNuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaNuovo.Image = ((System.Drawing.Image)(resources.GetObject("btnCreaNuovo.Image")));
            this.btnCreaNuovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreaNuovo.Location = new System.Drawing.Point(655, 134);
            this.btnCreaNuovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreaNuovo.Name = "btnCreaNuovo";
            this.btnCreaNuovo.Size = new System.Drawing.Size(100, 100);
            this.btnCreaNuovo.TabIndex = 21;
            this.btnCreaNuovo.UseVisualStyleBackColor = false;
            this.btnCreaNuovo.Click += new System.EventHandler(this.btnCreaNuovo_Click);
            // 
            // frmCerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.btnCreaNuovo);
            this.Controls.Add(this.btnVisualizzaElenco);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCerca";
            this.Text = "Gestore Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCerca;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVisualizzaElenco;
        private System.Windows.Forms.Button btnCreaNuovo;
    }
}