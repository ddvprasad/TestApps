using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApi.Controllers
{
    [RoutePrefix("api/DDV")]
    public class HomeController : ApiController
    {
        [Route("GetPrograms")]
        public IHttpActionResult GetPrograms()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                List<string> programs = new List<string>();
                programs.Add("11111111111");
                programs.Add("22222222222");
                programs.Add("33333333333");
                programs.Add("44444444444");
                programs.Add("66666666666");
                programs.Add("77777777777");
                return Ok(programs);
            }
            catch (Exception ex)
            {
                return BadRequest("Message: " + ex.Message + "StackTrace: " + ex.StackTrace);
            }

        }

    }
}