using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class cl_Calculo
    {
        private double percentagem_1 = 5;
        private double percentagem_2 = 10;
        private double percentagem_3 = 20;
        private double percentagem_4 = 25;
        private double percentagem_5 = 30;

        public double CalculaPrecoFinal(double precoInicial, double tipoProduto)
        {
            double precoFinal = 0;

            switch (tipoProduto)
            {
                case 1:
                    precoFinal = precoInicial + (precoInicial * (percentagem_1 / 100));
                    break;

                case 2:
                    precoFinal = precoInicial + (precoInicial * (percentagem_2 / 100));
                    break;

                case 3:
                    precoFinal = precoInicial + (precoInicial * (percentagem_3 / 100));
                    break;

                case 4:
                    precoFinal = precoInicial + (precoInicial * (percentagem_4 / 100));
                    break;

                case 5:
                    precoFinal = precoInicial + (precoInicial * (percentagem_5 / 100));
                    break;
            }
            return precoFinal;
        }
    }
}
