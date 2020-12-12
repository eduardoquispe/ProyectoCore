using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class CursoDocente
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int DocenteId { get; set; }
        public Docente Docente { get; set; }
    }
}
