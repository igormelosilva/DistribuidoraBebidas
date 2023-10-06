using Microsoft.AspNetCore.Mvc;
using ApiDistribuidora.Models;
using ApiDistribuidora.Global;

namespace ApiDistribuidora.Controllers
{
    [ApiController]
    [Route("api/DistribuidoraBebidas")]
    public class DrinkController : Controller
    {
        [HttpGet]
        [Route("Handshake")]

        public JsonResult Handshake()
        {
            Result result = new Result();
            result.success = true;
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("AccessTest")]
        public JsonResult AccessTest(string token)
        {
            Result result = new Result();

            try
            {
                if (token == Config.token) 
                {
                    if (Config.lifeToken >= DateTime.Now)
                    {
                        result.success = true;                    
                    }
                }

            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("Login")]
        public JsonResult Login(string user, string pass) 
        {
            try
            {
                Result result = new Result { success = true };
                if (user == "teste" && pass == "teste")
                {
                    Config.token = Guid.NewGuid().ToString();
                    Config.lifeToken = DateTime.Now.AddSeconds(30);
                }
                else
                {
                    result.success = false;
                    return new JsonResult(result.success);
                }
                result.data = Config.token;
                return new JsonResult(result);

            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            
        }

    }
}
