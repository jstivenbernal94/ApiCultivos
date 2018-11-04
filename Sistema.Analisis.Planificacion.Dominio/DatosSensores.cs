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
        public String Cultivo { get; set; }

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
    }

    public class otroobje
    {
        public List<string> content { get; set; }
    }
    
}
