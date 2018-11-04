using System.Collections.Generic;
using Sistema.Analisis.Planificacion.Dominio;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace Sistema.Analisis.Planificacion.Contrato
{
    [ServiceContract]
    public interface ISensoresService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Sensores", BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        List<DatosSensores> ObtenerDatosSensores();
    }
}
