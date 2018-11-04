using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Analisis.Planificacion.Dominio;
using Sistema.Analisis.Planificacion.ContratoRepositorio;
using Sistema.Analisis.Planificacion.FireBaseRepositorio;

namespace Sistema.Analisis.Planificacion.Fachada
{
    public class SensoresFachada : IDisposable
    {        
        public List<DatosSensores> ObtenerDatosSensores()
        {
            ISensoresRespositorio instancia = new SensoresRepositorio();
            return instancia.ObtenerDatosSensores();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
