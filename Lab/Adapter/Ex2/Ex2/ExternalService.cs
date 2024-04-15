using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json.Nodes;

namespace Ex2
{
    public class ExternalService
    {
        public class VCBService
        {
            public async Task<XDocument> FetchExchangeRates()
            {
                const string requestUri = "https://portal.vietcombank.com.vn/Usercontrols/TVPortal.TyGia/pXML.aspx?b=10";
                using var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(requestUri);
                return XDocument.Parse(response);
            }
        }


        public class DABService
        {
            public async Task<string> GetExchangeRates()
            {
                using var httpClient = new HttpClient();
                var req = new HttpRequestMessage(HttpMethod.Get, "https://www.dongabank.com.vn/exchange/export");
                req.Headers.Add("Accept", "*/*");
                var response = await httpClient.SendAsync(req);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                return data;
            }
        }
    }
}
