using BSAC_Voronov_Chekushin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BSAC_Voronov_Chekushin.Controllers.API
{
    [RoutePrefix("api/external")]
    public class ApiExternalRequestController : ApiController
    {

        private readonly ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        [Route("contact-us")]
        [HttpPost]
        public async Task<IHttpActionResult> ContactUsAsync(Contact model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ошибка! Проверьте правильность введенных данных");
            }
            applicationDbContext.Set<Contact>().Add(model);
            await applicationDbContext.SaveChangesAsync();
            return Ok();
        }

        [Route("reserve-table")]
        [HttpPost]
        public async Task<IHttpActionResult> ReserveTableAsync(Reservation model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ошибка! Проверьте правильность введенных данных");
            }
            applicationDbContext.Set<Reservation>().Add(model);
            await applicationDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
