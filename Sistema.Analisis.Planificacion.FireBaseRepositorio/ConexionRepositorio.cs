using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Sistema.Analisis.Planificacion.FireBaseRepositorio
{
    public class ConexionRepositorio
    {       
        public IFirebaseClient ConectarseFireBase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "rvGNu9ztg6g2VeDV5dthZEOdVHafKmsfEszvMIXk",
                BasePath = "https://popo-8f6bd.firebaseio.com/"
            };

            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            return client;
        }
    }
}
