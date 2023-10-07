using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistribuidoraBebidas.Api;
using DistribuidoraBebidas.Global;
using DistribuidoraBebidas.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace DistribuidoraBebidas.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblToken.Text = Config.token;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            ApiDrink apiDrink = new ApiDrink();
            Result result = apiDrink.Handshake();

            if (result.success == true)
            {
                lblAguardando.Text = "Retorno True";
                Log.Save("HandShake Recebido com sucesso");
            }
            else
            {
                lblAguardando.Text = "Erro ao receber HandShake";
                Log.Save("Erro ao receber HandShake");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAguardando.Text = "Aguardando nova solicitação";
        }

        private void btnEnviarAccess_Click(object sender, EventArgs e)
        {
            ApiDrink apiDrink = new ApiDrink();
            Security security = new Security();
            Result result = apiDrink.AccessTest(security.EncryptTripleDES(Config.token));
            if (result.success == true)
            {
                lblAcessTest.Text = "True";
                Log.Save("Validação do Token efetuada com sucesso");
            }
            else
            {
                lblAcessTest.Text = "False";
                result = apiDrink.Login(Config.user, Config.pass);
                Log.Save("Erro na Validação do Token");
                try
                {
                    if (result.success == true)
                    {
                        Config.token = result.data;
                        lblToken.Text = "Novo Token " + result.data;
                    }
                    else
                    {
                        lblAcessTest.Text = "Erro ao solicitar";
                        Log.Save("Erro ao solicitar o Token");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }
            }


        }
    }
}
