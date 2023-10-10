using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BE
{
    public class Libro
    {
        private string nombrelibro;
        private string autor;
        private string editorial;
        private string periodo;

        public string Nombrelibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Periodo { get; set; }
    }
}

