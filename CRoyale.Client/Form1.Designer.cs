﻿namespace CRoyale.Client
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AttackButtom = new System.Windows.Forms.Button();
            this.labelHP = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MiHP = new System.Windows.Forms.ProgressBar();
            this.MiVida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Not4l\\Documents\\programacion\\juegoProgra2\\Royale-master\\CRoyale.Client\\I" +
    "mages\\pekka vs golem.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(-7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AttackButtom
            // 
            this.AttackButtom.Location = new System.Drawing.Point(200, 202);
            this.AttackButtom.Name = "AttackButtom";
            this.AttackButtom.Size = new System.Drawing.Size(75, 23);
            this.AttackButtom.TabIndex = 2;
            this.AttackButtom.Text = "Atacar";
            this.AttackButtom.UseVisualStyleBackColor = true;
            this.AttackButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(368, 171);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(56, 16);
            this.labelHP.TabIndex = 3;
            this.labelHP.Text = "labelHP";
            this.labelHP.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(351, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // MiHP
            // 
            this.MiHP.Location = new System.Drawing.Point(27, 202);
            this.MiHP.Name = "MiHP";
            this.MiHP.Size = new System.Drawing.Size(100, 23);
            this.MiHP.TabIndex = 5;
            // 
            // MiVida
            // 
            this.MiVida.AutoSize = true;
            this.MiVida.Location = new System.Drawing.Point(49, 171);
            this.MiVida.Name = "MiVida";
            this.MiVida.Size = new System.Drawing.Size(50, 16);
            this.MiVida.TabIndex = 6;
            this.MiVida.Text = "Mi vida";
            this.MiVida.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 487);
            this.Controls.Add(this.MiVida);
            this.Controls.Add(this.MiHP);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.AttackButtom);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AttackButtom;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar MiHP;
        private System.Windows.Forms.Label MiVida;
    }
}

