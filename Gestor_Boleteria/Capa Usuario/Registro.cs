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

namespace Gestor_Boleteria.Capa_Usuario
{
    public partial class Registro : Form
    {
        DALUsuarios objCDusu = new DALUsuarios();
        public Registro()
        {
            InitializeComponent();
        }        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objCDusu.CrearUsuario (int.Parse(txtDocumento.Text), txtNom.Text, txtCorreo.Text, txtClave.Text);
            MessageBox.Show("Usuario Registrado");            

            Login login = new Login();
            login.Show(); //Regresar al login
            this.Hide();
        }
    }
}
