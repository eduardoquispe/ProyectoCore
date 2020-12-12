using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Docente
    {
        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Grado { get; set; }
        public byte[] FotoPerfil { get; set; }
        public ICollection<CursoDocente> CursoLink { get; set; }
    }
}
