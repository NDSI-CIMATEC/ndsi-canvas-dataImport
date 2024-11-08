using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NDSI_CanvasAPIConsumer.Template.DB
{
    public abstract class DBConnect
    {
        //TODO - Change this info to App.config
        private readonly string connectionString = "Integrated Security=SSPI;Persist Security Info=False;User ID=usr_integracao_canvas;Initial Catalog=dbIntegracaoCanvas;Data Source=SNP305-075\\ETL;Password=Canvas@123";


        public async void Select()
        {
            //Get connection and command constructor for DB
            SqlConnection connection = new SqlConnection(connectionString);

            throw new NotImplementedException();
        }

        public async void Insert()
        {
            //Get connection and command constructor for DB
            SqlConnection connection = new SqlConnection(connectionString);

            throw new NotImplementedException();
        }

        protected abstract string getQuery();
        public abstract Task<object> TreatResponse(HttpResponseMessage response);
    }
}
