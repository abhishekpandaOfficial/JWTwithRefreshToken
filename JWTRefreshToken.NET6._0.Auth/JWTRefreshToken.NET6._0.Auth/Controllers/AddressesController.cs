using JWTRefreshToken.NET6._0.Auth.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshToken.NET6._0.Auth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            List<Address> addresses = new()
            {
                new Address { Name = "Sarathlal Saseendran",
                    HouseName = "Chakkalayil House", 
                    City = "Karunagappally", State = "Kerala", Pin = 690574 },

                new Address { Name = "Aradhya Sarathlal",
                    HouseName = "Chakkalayil House", City = "Karunagappally",
                    State = "Kerala", Pin = 690574 },

                new Address { Name = "Anil Soman", HouseName = "Karoor Illam",
                    City = "Oachira", State = "Kerala", Pin = 690526 },
            };
            return addresses;
        }
    }
}
