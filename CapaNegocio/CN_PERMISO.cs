using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PERMISO
    {

        private CD_PERMISO objcd_Permiso = new CD_PERMISO();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_Permiso.Listar(IdUsuario);
        }
    }
}
