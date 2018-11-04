using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Sistema.Analisis.Planificacion.Dominio
{
    [DataContract]
    public class Error
    {
        [DataMember]
        public string NombreError { get; set; }

        [DataMember]
        public string DescripcionError { get; set; }


    }
}
