using DistribuidoraBebidas.Api;
using DistribuidoraBebidas.Forms;
using DistribuidoraBebidas.Global;
using DistribuidoraBebidas.Models;

namespace DistribuidoraBebidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                ApiDrink apiDrink = new ApiDrink();
                string user = txtUser.Text;
                string pass = txtPass.Text;
                Result result = apiDrink.Login(user, pass);

                if  (result.success == false)
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                    Log.Save("Usuario ou senha incorretos");
                }
                else
                {
                    Log.Save("Login efetuado com sucesso");
                    Config.user = user;
                    Config.pass = pass;
                    Config.token = result.data;  
                    Form2 form2 = new Form2();                   
                    form2.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }


        }
    }
}