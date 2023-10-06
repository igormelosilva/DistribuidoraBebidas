using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraBebidas.Global
{
    public class Config
    {
        public static string token;
        public static string tokenSecret;
        public static string user;
        public static string pass;
        public static string apiBaseUrl = "http://localhost:5198/api/DistribuidoraBebidas/";        
        //variaveis lidas do appsettings.json
        public static string fileName = string.Empty;
        public static string folderName = string.Empty;

        public static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string logName = ConfigurationManager.AppSettings["logFileName"];
        public static string logFolder = ConfigurationManager.AppSettings["logFilePath"];
        public static string logPath = Path.Combine(basePath, logFolder, logName);

        //Credenciais de acesso ao banco
        public static string dbHost = string.Empty;
        public static string dbPort = string.Empty;
        public static string dbName = string.Empty;
        public static string dbUser = string.Empty;
        public static string dbPass = string.Empty;

        


    }
    public enum LogType
    {
        success = 1,
        info = 2,
        error = 3
    }
    public enum LogSave
    {
        database = 1,
        file = 2
    }
}

