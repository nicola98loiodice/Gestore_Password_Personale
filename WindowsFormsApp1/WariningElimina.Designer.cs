namespace WindowsFormsApp1
{
    partial class frmWarningDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarningDelete));
            this.lblElimina = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElimina
            // 
            this.lblElimina.AutoSize = true;
            this.lblElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimina.Location = new System.Drawing.Point(13, 24);
            this.lblElimina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElimina.Name = "lblElimina";
            this.lblElimina.Size = new System.Drawing.Size(407, 36);
            this.lblElimina.TabIndex = 11;
            this.lblElimina.Text = "Sei sicuro di volere eliminare le seguenti credenziali?\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(479, 22);
            this.textBox1.TabIndex = 12;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(316, 130);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(179, 63);
            this.btnAnnulla.TabIndex = 21;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.Red;
            this.btnElimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(16, 130);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(179, 63);
            this.btnElimina.TabIndex = 22;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            // 
            // frmWarningDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 329);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblElimina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWarningDelete";
            this.Text = "Elimina credenziali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElimina;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnElimina;
    }
}