using System;
using System.Threading.Tasks;
using System.Web.Http;
using AxaptaApiApp.Utils;
using System.Web.Http.Description;
using AxaptaApiApp.PAX_APITestServiceGroup;


namespace AxaptaApiApp.Controllers
{
    public class TestAPIController : ApiController
    {
        private CallContext context = ClientFactory.CreateContext<CallContext>();
        // GET: TestAPI
        [HttpGet]
        [Route("testConnection")]
        [ResponseType(typeof(PAX_APITestServiceTestConnectionResponse))]
        public async Task<IHttpActionResult> testConnection()
        {
            try
            {
                using (var client = ClientFactory.CreateClient<PAX_APITestServiceClient>())
                {
                    var request = await client.testConnectionAsync(context);

                    return Ok(request.response);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("joke/{a:alpha};{b:alpha}")]
        [ResponseType(typeof(PAX_APITestServiceJokeResponse))]
        public async Task<IHttpActionResult> joke([FromUri] string a, [FromUri] string b)
        {
            try
            {
                using (var client = ClientFactory.CreateClient<PAX_APITestServiceClient>())
                {
                    var request = await client.jokeAsync(context, a, b);

                    return Ok(request.response);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}