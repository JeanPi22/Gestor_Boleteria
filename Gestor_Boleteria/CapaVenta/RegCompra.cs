using Gestor_Boleteria.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.CapaVenta
{
    class RegCompra
    {
       private DALCompra objCDcomp = new DALCompra();

        public void CrearCrearCompra(int cantidad, int idLocalidad)
        {
            objCDcomp.CrearCompra(cantidad,idLocalidad);
        }

        
    }
}
