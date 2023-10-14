using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribuidoraBebidas.Models;
using Newtonsoft.Json;

namespace DistribuidoraBebidas.Api
{
    public class ApiDrink 
    {
        public Result Handshake()
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("DistribuidoraBebidas/Handshake");
        }

        public Result Login(string user,string pass) 
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("DistribuidoraBebidas/Login?user=" + user+"&pass="+pass);

        }

        public Result AccessTest(string token)
        {
            ApiBase apiBase = new ApiBase();
            return apiBase.GetComand("DistribuidoraBebidas/AccessTest?token=" + token);
        }

        public List<Produto> GetAll() 
        {
            
            List<Produto> result = new List<Produto>();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("produtos/GetAll");

            result = JsonConvert.DeserializeObject<List<Produto>>(response.data);

            return result;

        }

    }
}
