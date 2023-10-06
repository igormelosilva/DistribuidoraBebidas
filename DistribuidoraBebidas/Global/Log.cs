using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraBebidas.Global
{
    public class Log
    {
        public static void Save(string msg)
        {
            try
            {
                //verifica se a pasta existe 
                if (!Directory.Exists(Path.Combine(Config.basePath, Config.logFolder))) ;
                {
                    Directory.CreateDirectory(Path.Combine(Config.basePath, Config.logFolder));
                }
                //verifica se o arquivo existe
                if (!File.Exists(Config.logPath))
                {

                    File.Create(Config.logPath).Dispose();
                }
                //grava o log no arquivo
                File.AppendAllText(Config.logPath, DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")
                    + " - " + msg + Environment.NewLine);

            }
            catch (Exception ex)
            {

  
            }
            
        }
    }
}
