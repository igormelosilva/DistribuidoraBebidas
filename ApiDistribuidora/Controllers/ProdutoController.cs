using Microsoft.AspNetCore.Mvc;
using ApiDistribuidora.DataBase;
using ApiDistribuidora.Models;
using ApiDistribuidora.Global;
using Newtonsoft.Json;

namespace ApiDistribuidora.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : Controller
    {
        [HttpGet]
        [Route("GetAll")]
        public Result GetAll()
        {
            Result result = new Result();
            try
            {

                List<Produto> produto = new List<Produto>();
                DbProdutos consulta = new DbProdutos();
                produto = consulta.GetAll();

                if (produto.Count > 0)
                {
                    Log.Save("Dados pegos com sucesso");
                    result.success = true;
                    result.data = JsonConvert.SerializeObject(produto);
                }
                else
                {
                    result.success = false;                   
                }


            }
            catch (Exception ex)
            {
                result.success = false;
            }
            return result;

        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add(Produto produto)
        {
            Result result = new Result();

            try
            {
                Produto produto2 = new Produto();

                DbProdutos consulta = new DbProdutos();
                produto.id = consulta.GetAll().Count + 1;

                //int id = consulta.GetAll().Count;
                //imv2 = consulta.GetId(id);
                //produto.id = imv2.id + 1;

                bool a = consulta.Add(produto);

                if (a)
                {
                    Log.Save("Dados adicionados com sucesso");
                    result.success = true;
                }
                else
                {
                    Log.Save("Erro ao adicionar dados");
                    result.success = false;
                }



            }
            catch (Exception ex)
            {
                Log.Save(ex.Message);
                result.success = false;                
            }

            return new JsonResult(result);

        }

        [HttpPut]
        [Route("Update")]
        public JsonResult Update(Produto produto)
        {
            Result result = new Result();

            try
            {
                DbProdutos consulta = new DbProdutos();
                bool updt = consulta.Update(produto);
                if (updt)
                {
                    Log.Save("Dados alterados com sucesso");
                    result.success = true;
                }
                else
                {
                    Log.Save("Erro ao alterar dados");
                    result.success = false;
                }

            }
            catch (Exception ex)
            {
                Log.Save(ex.Message);
                result.success = false;
            }

            return new JsonResult(result);
        }

        [HttpDelete]
        [Route("Delete")]
        public JsonResult Delete(int id)
        {
            Result result = new Result();

            try
            {
                DbProdutos consulta = new DbProdutos();
                bool dlt = consulta.Delete(id);
                if (dlt)
                {
                    Log.Save("Dados deletados com sucesso");
                    result.success = true;
                }
                else
                {
                    Log.Save("Erro ao deletar os dados");
                    result.success = false;
                }
            }


            catch (Exception ex)
            {
                Log.Save(ex.Message);
                result.success = false;
            }

            return new JsonResult(result);
        }
    }
}
