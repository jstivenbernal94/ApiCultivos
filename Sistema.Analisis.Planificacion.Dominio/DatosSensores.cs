using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Sistema.Analisis.Planificacion.Dominio
{
    [DataContract]
    public class DatosSensores
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Referencia { get; set; }

        [DataMember]
        public string Mac { get; set; }

        [DataMember]
        public string Propietario { get; set; }

        [DataMember]
        public String Consecutivo { get; set; }

        [DataMember]
        public string Fecha { get; set; }

        [DataMember]
        public int HumedadPow { get; set; }

        [DataMember]
        public int TemperaturaC { get; set; }

        [DataMember]
        public int TemperaturaF { get; set; }

        [DataMember]
        public string FC28 { get; set; }

        [DataMember]
        public string lumm { get; set; }
    }

}
