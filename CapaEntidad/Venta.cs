using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario oUsuario { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string NombreCliente { get; set; }

        public Decimal MontoPago { get; set; }
        public Decimal MontoCambio { get; set; }

        public Decimal MontoTotal { get; set; }
        public List<Detalle_Venta> detalle_Venta { get; set; }
        public string FechaRegistro { get; set; }

    }
}
