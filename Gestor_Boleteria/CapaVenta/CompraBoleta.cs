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
        
        public CompraBoleta(Login.Datos doc)
        {
            InitializeComponent();
            labDocBol.Text = "Documento: " + doc.Documento;
        }

        private void CamposCompraAct()
        {
            
        }

        private void CompraBoleta_Load(object sender, EventArgs e)
        {

        }
    }
}
