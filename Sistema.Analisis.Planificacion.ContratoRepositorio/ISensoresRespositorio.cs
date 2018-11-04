using Sistema.Analisis.Planificacion.Dominio;
using System.Collections.Generic;

namespace Sistema.Analisis.Planificacion.ContratoRepositorio
{
    public interface ISensoresRespositorio
    {
        List<DatosSensores> ObtenerDatosSensores();
    } 
}
