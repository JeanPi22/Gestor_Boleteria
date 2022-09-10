using Gestor_Boleteria.Capa_Usuario;
using Gestor_Boleteria.CapaDatos;
using Gestor_Boleteria.CapaVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Boleteria
{
    public partial class Login : Form
    {
        DALUsuarios objCDusu = new DALUsuarios();
        public Login()
        {
            InitializeComponent();
        }

        //Estructura para pasar dato del documento al formulario de compra
        public struct Datos
        {
            public int Documento;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show(); //Abrir ventana del formulario de registro
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            objCDusu.LeerUsuario(int.Parse(txtLogDoc.Text), txtCont.Text);

            Datos doc; // Guardar dato para el otro formulario
            doc.Documento = int.Parse(txtLogDoc.Text);

            CompraBoleta compra = new CompraBoleta(doc);
            compra.Show(); //Ir a la ventana de compra
            this.Hide();
        }
    }
}
