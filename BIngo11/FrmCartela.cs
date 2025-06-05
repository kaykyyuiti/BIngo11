using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmCartela : Form
    {
        FrmSorteador sorteador;
        public int id;
        int[][] numeros;
        Label[][] posicoes;
        //int[][] intervalos;
        int sorteados;

        public FrmCartela(FrmSorteador sorteador, int id)
        {
            InitializeComponent();
            this.id = id;
            this.sorteador = sorteador;
            numeros = new int[5][]
            {
                new int [5],
                new int [5],
                new int [5],
                new int [5],
                new int [5]
            };
            posicoes = new Label[5][]
            {
                new Label[5]{lbl1_1, lbl1_2, lbl1_3, lbl1_4, lbl1_5},
                new Label[5]{lbl2_1, lbl2_2, lbl2_3, lbl2_4, lbl2_5},
                new Label[5]{lbl3_1, lbl3_2, null , lbl3_4, lbl3_5},
                new Label[5]{lbl4_1, lbl4_2, lbl4_3, lbl4_4, lbl4_5},
                new Label[5]{lbl5_1, lbl5_2, lbl5_3, lbl5_4, lbl5_5}
            };

            /*intervalos = new int[5][]
            {
                new int[] { 1, 15 },
                new int[] { 16, 30 },
                new int[] { 31, 45 },
                new int[] { 46, 60 },
                new int[] { 61 , 75 }
            };*/

            sorteados = 0;
            CriarCartela();
        }

        void CriarCartela()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++) // i=> coluna E indicador de intervalo
            {
                for (int j = 0; j < 5; j++) // j => linha
                {
                    if (!(i == j && i == 2))
                    {
                        int n = r.Next(1, 16) + i * 15;
                        numeros[i][j] = n;
                        posicoes[i][j].Text = n.ToString();
                    }
                }
            }
        }

        public void ReceberNumero(int numero)
        {
            int i = (numero - 1) / 15;
            for (int j = 0; j < 5; j++)
            {
                if (numeros[i][j] == numero)
                {
                    posicoes[i][j].BackColor = Color.Yellow;
                    sorteados++;

                    if (sorteados == 25)
                    {
                        lblVitoria.Visible = true;
                        sorteador.AnunciarVitoria(this);
                    }
                }
            }

        }
    }
}

