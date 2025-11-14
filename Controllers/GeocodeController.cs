using GeocoderProxy.Models;
using GeocoderProxy.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Threading.Tasks;

namespace GeocoderProxy.Controllers
{
//[ApiController]Tells ASP.NET this class is an API controller(not a normal MVC controller).
    [ApiController]
    [Route("api/[controller]")]//This defines the URL path for endpoint [controller] means it will replace it with the name of the class → GeocodeController → so the path becomes:👉 https://localhost:7232/api/Geocode
    public class GeocodeController : ControllerBase
    {//controller class that inherits from ControllerBase (gives it API abilities like returning responses).
        private readonly GeocoderClient _geocoderClient;
//This is a dependency (your service) Instead of writing HTTP request code inside the controller, you offload it to GeocoderClient.
        public GeocodeController(GeocoderClient geocoderClient)
        {//This is constructor injection.
            _geocoderClient = geocoderClient;
        }

        [HttpPost]
        //This method will respond to POST requests (like when you hit "Send" in Postman).
        public async Task<ActionResult<GeocodeResponse>> Post([FromBody] GeocodeRequest request)
        {
            var response = await _geocoderClient.GetGeocodeAsync(request);
            return Ok(response);
        }
    }
}
        /*Defines the endpoint method.
        [FromBody] → tells ASP.NET to take the JSON body from the client and map it into a GeocodeRequest model.
        Returns GeocodeResponse wrapped in ActionResult (so you can control status codes).

         inside :
         Takes the request JSON, passes it to the service (GeocoderClient).
         Waits for the service to call Amazon and get the result.
         Returns the result as 200 OK with the GeocodeResponse.*/
