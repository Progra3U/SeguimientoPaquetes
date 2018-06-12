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

        #region ProcesoLogin
        public string iduser { get; set; }
        public string password { get; set; }
        //public string typeuser { get; set; }
        //public string typeuser { get; set; }
        //public string.nameUser { get; set; }
        //public stringtypeuser { get; set; }
        //public string.stateUser { get; set; }
        #endregion

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
