﻿
namespace Gestor_Boleteria.CapaVenta
{
    partial class CompraBoleta
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
            this.labDocBol = new System.Windows.Forms.Label();
            this.cmbTri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoBol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDocBol
            // 
            this.labDocBol.AutoSize = true;
            this.labDocBol.Location = new System.Drawing.Point(340, 127);
            this.labDocBol.Name = "labDocBol";
            this.labDocBol.Size = new System.Drawing.Size(80, 17);
            this.labDocBol.TabIndex = 0;
            this.labDocBol.Text = "Documento";
            // 
            // cmbTri
            // 
            this.cmbTri.FormattingEnabled = true;
            this.cmbTri.Location = new System.Drawing.Point(316, 245);
            this.cmbTri.Name = "cmbTri";
            this.cmbTri.Size = new System.Drawing.Size(121, 24);
            this.cmbTri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tribuna";
            // 
            // lblNoBol
            // 
            this.lblNoBol.AutoSize = true;
            this.lblNoBol.Location = new System.Drawing.Point(342, 178);
            this.lblNoBol.Name = "lblNoBol";
            this.lblNoBol.Size = new System.Drawing.Size(73, 17);
            this.lblNoBol.TabIndex = 3;
            this.lblNoBol.Text = "No. boleta";
            // 
            // CompraBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoBol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTri);
            this.Controls.Add(this.labDocBol);
            this.Name = "CompraBoleta";
            this.Text = "CompraBoleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDocBol;
        private System.Windows.Forms.ComboBox cmbTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoBol;
    }
}