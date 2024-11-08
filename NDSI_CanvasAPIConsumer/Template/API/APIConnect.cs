using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Xml.Linq;
using System.Net.Http.Headers;

namespace NDSI_CanvasAPIConsumer.Template.API
{
    public abstract class APIConnect
    {
        //TODO - Change the values location to App.config
        private readonly string BaseURL = "https://senaicimatec.instructure.com/api/v1";
        private readonly string CanvasToken = "20766~nXvZaCRVmvKmG3D42Zkc6WZaRX4NDuVvrJ4vxaV3y9EYcKDEuXJhh93RXDKffDNX";

        public async Task<HttpResponseMessage> SendGetRequestAsync()
        {
            //Get complete URL to be used
            string URL = BaseURL + URLComplement() + Params();

            //Client Handler
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            //Create a client and prepare to be used
            HttpClient client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri(@URL);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CanvasToken);

            //Send the request and store it into a response
            HttpResponseMessage response = await client.GetAsync(URL);

            return response;
        }

        protected abstract string URLComplement();
        protected abstract string Params();
        public abstract Task<object> TreatResponse(HttpResponseMessage response);
    }
}
