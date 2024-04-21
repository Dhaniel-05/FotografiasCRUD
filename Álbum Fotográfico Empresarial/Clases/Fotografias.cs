using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Álbum_Fotográfico_Empresarial.Clases
{
    public class Fotografias
    {
        public int IdFotogragias { get; set; }
        public byte[] Foto { get; set; }
        public string DescripcionImagen { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Lugar { get; set; }
        public string DescripcionEvento { get; set; }

        public Fotografias(int idfotografias, byte[] foto, string descripcionImagen, DateTime fechaEvento, string lugar, string descripcionEvento)
        {
            IdFotogragias = idfotografias;
            Foto = foto;
            DescripcionImagen = descripcionImagen;
            FechaEvento = fechaEvento;
            Lugar = lugar;
            DescripcionEvento = descripcionEvento;
        }
    }
}
