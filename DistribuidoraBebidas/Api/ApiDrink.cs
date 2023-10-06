using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribuidoraBebidas.Models;

namespace DistribuidoraBebidas.Api
{
    public class ApiDrink 
    {
        public Result Handshake()
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("Handshake");
        }

        public Result Login(string user,string pass) 
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("Login?user="+user+"&pass="+pass);

        }

        public Result AccessTest(string token)
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("AccessTest?token=" + token);
        }
    }
}
