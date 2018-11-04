using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Analisis.Planificacion.Contrato;
using Sistema.Analisis.Planificacion.Dominio;
using Sistema.Analisis.Planificacion.Fachada;

namespace Sistema.Analisis.Planificacion.Implementacion
{
    public class SensoresService : ISensoresService
    {
        public List<DatosSensores> ObtenerDatosSensores()
        {
            using (var instancia = new SensoresFachada())
            {
                return instancia.ObtenerDatosSensores();
            }
        }
    }
}
