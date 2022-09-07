using Gestor_Boleteria.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.Capa_Usuario
{
    class RegUsuario
    {
        private DALUsuarios objCDusu = new DALUsuarios();

        public void CrearUsuario(int documento, string nombre, string correo, string clave)
        {
            objCDusu.CrearUsuario(documento, nombre, correo, clave);
        }
    }
}
