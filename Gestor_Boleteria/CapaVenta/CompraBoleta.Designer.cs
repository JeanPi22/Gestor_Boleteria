
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
            this.cbselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoBol = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDocBol
            // 
            this.labDocBol.AutoSize = true;
            this.labDocBol.Location = new System.Drawing.Point(117, 117);
            this.labDocBol.Name = "labDocBol";
            this.labDocBol.Size = new System.Drawing.Size(80, 17);
            this.labDocBol.TabIndex = 0;
            this.labDocBol.Text = "Documento";
            this.labDocBol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbselect
            // 
            this.cbselect.FormattingEnabled = true;
            this.cbselect.Location = new System.Drawing.Point(86, 248);
            this.cbselect.Name = "cbselect";
            this.cbselect.Size = new System.Drawing.Size(121, 24);
            this.cbselect.TabIndex = 1;
            this.cbselect.SelectedIndexChanged += new System.EventHandler(this.cbselect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tribuna";
            // 
            // lblNoBol
            // 
            this.lblNoBol.AutoSize = true;
            this.lblNoBol.Location = new System.Drawing.Point(119, 156);
            this.lblNoBol.Name = "lblNoBol";
            this.lblNoBol.Size = new System.Drawing.Size(64, 17);
            this.lblNoBol.TabIndex = 3;
            this.lblNoBol.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(101, 188);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Location = new System.Drawing.Point(337, 40);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(78, 17);
            this.lbBienvenido.TabIndex = 5;
            this.lbBienvenido.Text = "Bienvenido";
            this.lbBienvenido.Click += new System.EventHandler(this.lbBienvenido_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(108, 346);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(119, 298);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 7;
            this.lbPrecio.Text = "Precio";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompraBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblNoBol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbselect);
            this.Controls.Add(this.labDocBol);
            this.Name = "CompraBoleta";
            this.Text = "CompraBoleta";
            this.Load += new System.EventHandler(this.CompraBoleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDocBol;
        private System.Windows.Forms.ComboBox cbselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoBol;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lbPrecio;
    }
}