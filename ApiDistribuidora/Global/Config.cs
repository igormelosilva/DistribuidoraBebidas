
using System.Xml.Linq;

namespace ApiDistribuidora.Global
{
    public class Config
    {
        
        public static string token = string.Empty;
        public static string tokenSecret = string.Empty;
        public static DateTime lifeToken;

        //variaveis lidas do appsettings.json
        public static string fileName = string.Empty;
        public static string folderName = string.Empty;


        //caminhos
        public static string basePath = string.Empty;
        public static string filePath = string.Empty;
        public static string folderPath = string.Empty;

        //Credenciais de acesso ao banco
        public static string dbHost = string.Empty;
        public static string dbPort = string.Empty;
        public static string dbName = string.Empty;
        public static string dbUser = string.Empty;
        public static string dbPass = string.Empty;

        public static void LoadConfigurations()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            try
            {
                fileName = config.GetValue<string>("Log:FileName");
                folderName = config.GetValue<string>("Log:Foldername");
                dbHost = config.GetValue<string>("dbHost");
                dbPort = config.GetValue<string>("dbPort");
                dbName = config.GetValue<string>("dbName");
                dbUser = config.GetValue<string>("dbUser");
                dbPass = config.GetValue<string>("dbPass");

                basePath = AppDomain.CurrentDomain.BaseDirectory;

                folderPath = Path.Combine(basePath, folderName);

                filePath = Path.Combine(folderPath, fileName);



            }
            catch (Exception ex)
            {

            }
        }
    }
}
