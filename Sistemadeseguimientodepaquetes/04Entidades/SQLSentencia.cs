using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Entidades
{
    public class SQLSentencia
    {
        private string peticion;

        public SQLSentencia()
        {
            this.peticion = string.Empty;
        }
        public string PETICION
        {
            set { this.peticion = value; }
            get { return this.peticion; }
        }
    }
}
