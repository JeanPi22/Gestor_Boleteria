
namespace Gestor_Boleteria.Capa_Usuario
{
    partial class Registro
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
            this.lbDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labNom = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.labCorreo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.labClave = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(322, 79);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDocumento.Size = new System.Drawing.Size(80, 17);
            this.lbDocumento.TabIndex = 0;
            this.lbDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(181, 99);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(380, 22);
            this.txtDocumento.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(181, 156);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(380, 22);
            this.txtNom.TabIndex = 3;
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(291, 136);
            this.labNom.Name = "labNom";
            this.labNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labNom.Size = new System.Drawing.Size(137, 17);
            this.labNom.TabIndex = 2;
            this.labNom.Text = "Nombres y Apellidos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(181, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(380, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Location = new System.Drawing.Point(339, 193);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labCorreo.Size = new System.Drawing.Size(51, 17);
            this.labCorreo.TabIndex = 4;
            this.labCorreo.Text = "Correo";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(181, 270);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(380, 22);
            this.txtClave.TabIndex = 7;
            // 
            // labClave
            // 
            this.labClave.AutoSize = true;
            this.labClave.Location = new System.Drawing.Point(339, 250);
            this.labClave.Name = "labClave";
            this.labClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labClave.Size = new System.Drawing.Size(43, 17);
            this.labClave.TabIndex = 6;
            this.labClave.Text = "Clave";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(325, 319);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.labClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.labCorreo);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lbDocumento);
            this.Name = "Registro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label labCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label labClave;
        private System.Windows.Forms.Button btnRegistrar;
    }
}