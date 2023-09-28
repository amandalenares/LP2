using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSS_IRRF
{
    public partial class Form1 : Form
    {
        double SalBruto, SalFamilia, SalLiquido, DescINSS, DescIRPF;
        int NumFilhos;
        char NomeFunc;

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if(!Double.TryParse(mskbxsalariob.Text, out SalBruto))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente!");
                
                    mskbxsalariob.Focus();
            }
            else
            {
                Double.TryParse(mskbxsalariob.Text, out SalBruto);
                int.TryParse(numfilhos.Text, out NumFilhos);

                if (SalBruto <= 800.47)
                {
                    txtaliqinss.Text = "7,65%";
                    DescINSS = 0.0765 * SalBruto;
                }
                else if (SalBruto <= 1050)
                {
                    txtaliqinss.Text = "8,65%";
                    DescINSS = 0.0865 * SalBruto;
                }
                else if (SalBruto <= 1400.17)
                {
                    txtaliqinss.Text = "9,00%";
                    DescINSS = 0.09 * SalBruto;
                }
                else if (SalBruto <= 2801.56)
                {
                    txtaliqinss.Text = "11,00%";
                    DescINSS = 0.11 * SalBruto;
                }
                else
                {
                    txtaliqinss.Text = "27,50%";
                    DescINSS = 0.275 * SalBruto;
                }

                if (SalBruto <= 1257.12)
                {
                    txtaliqirpf.Text = "Insento";
                    DescIRPF = 0;
                }
                else if (SalBruto <= 2512.08)
                {
                    txtaliqirpf.Text = "15,00%";
                    DescIRPF = 0.15 * SalBruto;
                }
                else
                {
                    txtaliqirpf.Text = "27,50%";
                    DescIRPF = 0.275 * SalBruto;
                }

                if (SalBruto <= 435.32)
                {
                    SalFamilia = NumFilhos * 22.33;
                    txtsalariof.Text = SalFamilia.ToString();
                }
                else if (SalBruto <= 654.61)
                {
                    SalFamilia = NumFilhos * 15.74;
                    txtsalariof.Text = SalFamilia.ToString();
                }
                else
                {
                    txtsalariof.Text = "R$ 0,00";
                    SalFamilia = 0;
                }

                txtdescinss.Text = DescINSS.ToString();
                txtdescirpf.Text = DescIRPF.ToString();

                SalLiquido = SalBruto + SalFamilia - DescINSS - DescIRPF;
                txtsalariol.Text = SalLiquido.ToString();
            }
        }
           

        private void txtnome_Validated(object sender, EventArgs e)
        {
            
        }

        private void mskbxsalariob_Validated(object sender, EventArgs e)
        {
            errorSalBruto.SetError(mskbxsalariob, "");

            if (!Double.TryParse(mskbxsalariob.Text, out SalBruto))
            {
                errorSalBruto.SetError(mskbxsalariob, "Valor salário inválido!");
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
