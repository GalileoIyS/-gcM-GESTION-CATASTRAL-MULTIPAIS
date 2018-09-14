using AspNetCoreApplication.Models.vw_spatial_unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Controllers
{
    [Produces("application/json")]
    [EnableCors("AllowCors"), Route("api/detalle")]
    public class DetalleController : Controller
    {

        //INICIALIZAMOS EL REGISTRO PARA INSERTAR
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { success = true });
        }

        //OBTENEMOS EL REGISTRO DE LA BASE DE DATOS
        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            return Json(new DetailViewModel(id));
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] GetFeatureInfo info)
        {
            string result = "";

            // Create the web request  
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(info.address);

            // Get response  
            try
            {
                using (System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse())
                {
                    // Get the response stream  
                    System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("ISO-8859-1"));

                    // Read the whole contents and return as a string  
                    result = reader.ReadToEnd();
                    return Json(result);
                }
            }
            catch
            {

                //using (var client = new System.Net.Http.HttpClient())
                //{
                //    client.BaseAddress = new System.Uri(info.address);
                //    client.DefaultRequestHeaders.Accept.Clear();
                //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //    System.Net.Http.HttpResponseMessage response = await client.GetAsync(info.address);

                //    if (response.IsSuccessStatusCode)
                //    {
                //        string responseString = response.Content.ReadAsStringAsync().Result;

                //        return Json(Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseString));
                //    }

                //}

                return Json(result);
            }
        }
    }
}
