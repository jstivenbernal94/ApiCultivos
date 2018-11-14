using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireSharp.Config;
using FireSharp.Serialization;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;
using Sistema.Analisis.Planificacion.ContratoRepositorio;
using Sistema.Analisis.Planificacion.Dominio;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace Sistema.Analisis.Planificacion.FireBaseRepositorio
{
    public class SensoresRepositorio : ISensoresRespositorio
    {
        public List<DatosSensores> ObtenerDatosSensores()
        {
            List<DatosSensores> Result = null;
            Task.Run(async () => Result = await ObtenerDatosSensoresAsync()).Wait();
            return Result;
        }

        public async Task<List<DatosSensores>> ObtenerDatosSensoresAsync()
        {
            ConexionRepositorio cnn = new ConexionRepositorio();
            IFirebaseClient client = cnn.ConectarseFireBase();
            List<DatosSensores> Result = new List<DatosSensores>();

            FirebaseResponse response = await client.GetTaskAsync("LECTURAS");
            string chrr = response.Body;

            dynamic dynJson = JsonConvert.DeserializeObject(chrr);
            foreach (var item in dynJson)
            {
                DatosSensores respu = new DatosSensores();
                foreach (var tm in item)
                {
                    respu.Id = tm.Id;
                    respu.Mac = tm.Mac;
                    respu.Propietario = tm.Propietario;
                    respu.Referencia = tm.Referencia;
                    respu.Consecutivo = tm.Consecutivo;
                    respu.Fecha = tm.Fecha;
                    respu.HumedadPow = tm.HumedadPow;
                    respu.TemperaturaC = tm.TemperaturaC;
                    respu.TemperaturaF = tm.TemperaturaF;
                    respu.FC28 = tm.fc28;
                    respu.lumm = tm.luz;
                }
                Result.Add(respu);
            }
            //DatosSensores resp = response.ResultAs<DatosSensores>();
            return Result;
        }
    }
}
