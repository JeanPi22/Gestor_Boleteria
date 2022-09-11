using Gestor_Boleteria.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Boleteria.CapaVenta
{
    public partial class CompraBoleta : Form    {
        
        private DALCompra objCDcomp = new DALCompra();
        public CompraBoleta(Login.Datos doc)
        {
            InitializeComponent();
            labDocBol.Text = "Documento: " + doc.Documento;
            objCDcomp.CargarCombo(cbselect);           
        }

        private void CamposCompraAct()
        {
            
        }

        private void CompraBoleta_Load(object sender, EventArgs e)
        {

        }

        private void lbBienvenido_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            objCDcomp.CrearCompra(int.Parse(txtCantidad.Text), cbselect.SelectedIndex);
            MessageBox.Show("Compra realizada");              
        }

        private void cbselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbselect.SelectedIndex>0)
            {
                string[] valores = objCDcomp.capturarInfo(cbselect.Text);
                lbPrecio.Text = "Costo: " + valores[0];
            }            
        }
    }
}
