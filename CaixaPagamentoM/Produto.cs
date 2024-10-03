using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CaixaPagamentoM
{
    internal class Produto
    {
        public int QuantidadeDeProdutos;

        //Produto 1
        public string NomeProdutoUm;
        public double PreçoUm;
        public int EstoqueUm;
        //Produto 2 
        public string NomeProdutoDois;
        public double PreçoDois;
        public int EstoqueDois;
        //Produto 3 
        public string NomeProdutoTrês;
        public double PreçoTrês;
        public int EstoqueTrês;
        //Produto 4 
        public string NomeProdutoQuatro;
        public double PreçoQuatro;
        public int EstoqueQuatro;
        //Produto 5 
        public string NomeProdutoCinco;
        public double PreçoCinco;
        public int EstoqueCinco;


        public override string ToString()
        {   
            if (QuantidadeDeProdutos == 1)
            {
                return "1-" + NomeProdutoUm + "  Preço:$" + PreçoUm + " Estoque:" + EstoqueUm + "\n";
            }
            else if (QuantidadeDeProdutos == 2) 
            {
                return "1-" + NomeProdutoUm + "  Preço:$" + PreçoUm + " Estoque:" + EstoqueUm + "\n" +
                "2-" + NomeProdutoDois + "  Preço:$" + PreçoDois + " Estoque:" + EstoqueDois + "\n";
            }
            else if(QuantidadeDeProdutos == 3)
            {
                return "1-" + NomeProdutoUm + "  Preço:$" + PreçoUm + " Estoque:" + EstoqueUm + "\n" +
                "2-" + NomeProdutoDois + "  Preço:$" + PreçoDois + " Estoque:" + EstoqueDois + "\n" +
                "3-" + NomeProdutoTrês + "  Preço:$" + PreçoTrês + " Estoque:" + EstoqueTrês + "\n";
            }
            else if(QuantidadeDeProdutos == 4)
            {
                return "1-" + NomeProdutoUm + "  Preço:$" + PreçoUm + " Estoque:" + EstoqueUm + "\n" +
                "2-" + NomeProdutoDois + "  Preço:$" + PreçoDois + " Estoque:" + EstoqueDois + "\n" +
                "3-" + NomeProdutoTrês + "  Preço:$" + PreçoTrês + " Estoque:" + EstoqueTrês + "\n" +
                "4-" + NomeProdutoQuatro + "  Preço:$" + PreçoQuatro + " Estoque:" + EstoqueQuatro + "\n";
            }
            else if(QuantidadeDeProdutos == 5)
            {
                return "1-" + NomeProdutoUm + "  Preço:$" + PreçoUm + " Estoque:" + EstoqueUm + "\n" +
               "2-" + NomeProdutoDois + "  Preço:$" + PreçoDois + " Estoque:" + EstoqueDois + "\n" +
               "3-" + NomeProdutoTrês + "  Preço:$" + PreçoTrês + " Estoque:" + EstoqueTrês + "\n" +
               "4-" + NomeProdutoQuatro + "  Preço:$" + PreçoQuatro + " Estoque:" + EstoqueQuatro + "\n" +
               "5-" + NomeProdutoCinco + "  Preço:$" + PreçoCinco + " Estoque:" + EstoqueCinco + "\n";
            }
            return "\n";
        }
        
    }
}
