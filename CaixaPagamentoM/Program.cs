using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CaixaPagamentoM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto prod = new Produto();
            Console.WriteLine("Você gostaria de ter quantos Produtos: ");
            Console.WriteLine("obs:Limite 5");
            prod.QuantidadeDeProdutos = int.Parse(Console.ReadLine());

            // 1 só Produto
            if (prod.QuantidadeDeProdutos == 1)
            {
                //Add Produto 1
                Console.WriteLine("Coloque o nome do 1º Produto");
                prod.NomeProdutoUm = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 1º Produto");
                prod.PreçoUm = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 1º ");
                prod.EstoqueUm = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            // 2 Produtos 
            if (prod.QuantidadeDeProdutos == 2)
            {
                //add Produto 1
                Console.WriteLine("Coloque o nome do 1º Produto");
                prod.NomeProdutoUm = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 1º Produto");
                prod.PreçoUm = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 1º ");
                prod.EstoqueUm = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 2 
                Console.WriteLine("Coloque o nome do 2º Produto");
                prod.NomeProdutoDois = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 2º Produto");
                prod.PreçoDois = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 2º ");
                prod.EstoqueDois = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            // 3 Produtos 
            if (prod.QuantidadeDeProdutos == 3)
            {
                //add Produto 1 
                Console.WriteLine("Coloque o nome do 1º Produto");
                prod.NomeProdutoUm = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 1º Produto");
                prod.PreçoUm = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 1º ");
                prod.EstoqueUm = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 2 
                Console.WriteLine("Coloque o nome do 2º Produto");
                prod.NomeProdutoDois = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 2º Produto");
                prod.PreçoDois = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 2º ");
                prod.EstoqueDois = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 3
                Console.WriteLine("Coloque o nome do 3º Produto");
                prod.NomeProdutoTrês = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 3º Produto");
                prod.PreçoTrês = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 3º ");
                prod.EstoqueTrês = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            // 4  Produtos 
            if (prod.QuantidadeDeProdutos == 4)
            {
                //add Produto 1 
                Console.WriteLine("Coloque o nome do 1º Produto");
                prod.NomeProdutoUm = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 1º Produto");
                prod.PreçoUm = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 1º ");
                prod.EstoqueUm = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 2 
                Console.WriteLine("Coloque o nome do 2º Produto");
                prod.NomeProdutoDois = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 2º Produto");
                prod.PreçoDois = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 2º ");
                prod.EstoqueDois = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 3
                Console.WriteLine("Coloque o nome do 3º Produto");
                prod.NomeProdutoTrês = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 3º Produto");
                prod.PreçoTrês = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 3º ");
                prod.EstoqueTrês = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 4 
                Console.WriteLine("Coloque o nome do 4º Produto");
                prod.NomeProdutoQuatro = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 4º Produto");
                prod.PreçoQuatro = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 4º ");
                prod.EstoqueQuatro = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            // 5 Produtos 
            if (prod.QuantidadeDeProdutos == 5)
            {
                //add Produto 1 
                Console.WriteLine("Coloque o nome do 1º Produto");
                prod.NomeProdutoUm = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 1º Produto");
                prod.PreçoUm = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 1º ");
                prod.EstoqueUm = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 2 
                Console.WriteLine("Coloque o nome do 2º Produto");
                prod.NomeProdutoDois = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 2º Produto");
                prod.PreçoDois = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 2º ");
                prod.EstoqueDois = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 3
                Console.WriteLine("Coloque o nome do 3º Produto");
                prod.NomeProdutoTrês = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 3º Produto");
                prod.PreçoTrês = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 3º ");
                prod.EstoqueTrês = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 4 
                Console.WriteLine("Coloque o nome do 4º Produto");
                prod.NomeProdutoQuatro = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 4º Produto");
                prod.PreçoQuatro = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 4º ");
                prod.EstoqueQuatro = int.Parse(Console.ReadLine());
                Console.Clear();
                //add Produto 5
                Console.WriteLine("Coloque o nome do 5º Produto");
                prod.NomeProdutoCinco = Console.ReadLine();
                Console.WriteLine("Coloque o Preço do 5º Produto");
                prod.PreçoCinco = double.Parse(Console.ReadLine());
                Console.WriteLine("Coloque a quantidade no estoque do Produto 5º ");
                prod.EstoqueCinco = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            bool repetiçao = true;
            while (repetiçao)
            {
                Console.WriteLine("1-Realizar Pagamento");
                Console.WriteLine("2-Atualizar Estoque");
                Console.WriteLine("3-Atualizar Produto");
                Console.WriteLine("4-Tabela Atualizado");
                Console.WriteLine("5-Sair");
                int escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                //Realizar Pagamento
                if (escolha == 1)
                {
                    Console.WriteLine(prod.ToString());
                    Console.WriteLine("Coloque o numero do Produto desejado");
                    int escolhaProdutoPagamento = int.Parse(Console.ReadLine());
                    Console.Clear();
                    //Produto 1 
                    if (escolhaProdutoPagamento == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual Seria a forma de Pagamento: ");
                        Console.WriteLine("1-Cartão");
                        Console.WriteLine("2-Dinhero");
                        int escolhaDinheroOuCartao = int.Parse(Console.ReadLine());
                        //Cartão 
                        if (escolhaDinheroOuCartao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1-Credito");
                            Console.WriteLine("2-Debito");
                            int escolhaCreditoOuDebito = int.Parse(Console.ReadLine());
                            //Credito 
                            if (escolhaCreditoOuDebito == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você Gostaria De parcela em quantas Vezes:");
                                double parcelaMento = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Processando...");
                                Task.Delay(200).Wait();
                                Console.Clear();
                                double parcelas = prod.PreçoUm / parcelaMento;
                                Console.WriteLine($"Ficara {parcelaMento}x de {parcelas}");
                                Console.WriteLine($"Para Compar {prod.NomeProdutoUm} de {prod.PreçoUm}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                            //Debito
                            else if (escolhaCreditoOuDebito == 2)
                            {
                                Console.WriteLine($"Para Compar {prod.NomeProdutoUm} de {prod.PreçoUm}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                        }
                        //Dinhero
                        else if (escolhaDinheroOuCartao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Na Compara de {prod.NomeProdutoUm} ficara ${prod.PreçoUm}");
                            Console.WriteLine("Valor dado: ");
                            double valorDado = int.Parse(Console.ReadLine());
                            double troco = valorDado - prod.PreçoUm;
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Console.WriteLine("Compar Aprovada");
                            Console.WriteLine("Obrigado por Compar Aqui !!");
                            Console.WriteLine($"Troco ${troco}");
                            Console.ReadLine();
                        }
                        prod.EstoqueUm -= 1;
                    }
                    //Produto 2 
                    else if (escolhaProdutoPagamento == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual Seria a forma de Pagamento: ");
                        Console.WriteLine("1-Cartão");
                        Console.WriteLine("2-Dinhero");
                        int escolhaDinheroOuCartao = int.Parse(Console.ReadLine());
                        //Cartão 
                        if (escolhaDinheroOuCartao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1-Credito");
                            Console.WriteLine("2-Debito");
                            int escolhaCreditoOuDebito = int.Parse(Console.ReadLine());
                            //Credito 
                            if (escolhaCreditoOuDebito == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você Gostaria De parcela em quantas Vezes:");
                                double parcelaMento = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Processando...");
                                Task.Delay(200).Wait();
                                Console.Clear();
                                double parcelas = prod.PreçoDois / parcelaMento;
                                Console.WriteLine($"Ficara {parcelaMento}x de {parcelas}");
                                Console.WriteLine($"Para Compar {prod.NomeProdutoDois} de {prod.PreçoDois}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                            else if (escolhaCreditoOuDebito == 2)
                            {
                                Console.WriteLine($"Para Compar {prod.NomeProdutoDois} de {prod.PreçoDois}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                        }
                        //Dinhero
                        else if (escolhaDinheroOuCartao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Na Compara de {prod.NomeProdutoDois} ficara ${prod.PreçoDois}");
                            Console.WriteLine("Valor dado: ");
                            double valorDado = int.Parse(Console.ReadLine());
                            double troco = valorDado - prod.PreçoDois;
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Console.WriteLine("Compar Aprovada");
                            Console.WriteLine("Obrigado por Compar Aqui !!");
                            Console.WriteLine($"Troco ${troco}");
                            Console.ReadLine();
                        }
                        prod.EstoqueDois -= 1;               
                    }
                    //Produto 3 
                    else if (escolhaProdutoPagamento == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual Seria a forma de Pagamento: ");
                        Console.WriteLine("1-Cartão");
                        Console.WriteLine("2-Dinhero");
                        int escolhaDinheroOuCartao = int.Parse(Console.ReadLine());
                        //Cartão 
                        if (escolhaDinheroOuCartao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1-Credito");
                            Console.WriteLine("2-Debito");
                            int escolhaCreditoOuDebito = int.Parse(Console.ReadLine());
                            //Credito 
                            if (escolhaCreditoOuDebito == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você Gostaria De parcela em quantas Vezes:");
                                double parcelaMento = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Processando...");
                                Task.Delay(200).Wait();
                                Console.Clear();
                                double parcelas = prod.PreçoTrês / parcelaMento;
                                Console.WriteLine($"Ficara {parcelaMento}x de {parcelas}");
                                Console.WriteLine($"Para Compar {prod.NomeProdutoTrês} de {prod.PreçoTrês}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                            else if (escolhaCreditoOuDebito == 2)
                            {
                                Console.WriteLine($"Para Compar {prod.NomeProdutoTrês} de {prod.PreçoTrês}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();



                            }
                        }
                        //Dinhero
                        else if (escolhaDinheroOuCartao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Na Compara de {prod.NomeProdutoTrês} ficara ${prod.PreçoTrês}");
                            Console.WriteLine("Valor dado: ");
                            double valorDado = int.Parse(Console.ReadLine());
                            double troco = valorDado - prod.PreçoTrês;
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Console.WriteLine("Compar Aprovada");
                            Console.WriteLine("Obrigado por Compar Aqui !!");
                            Console.WriteLine($"Troco ${troco}");
                            Console.ReadLine();
                        }
                        prod.EstoqueTrês -= 1;           
                    }

                    //Produto 4
                    else if (escolhaProdutoPagamento == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual Seria a forma de Pagamento: ");
                        Console.WriteLine("1-Cartão");
                        Console.WriteLine("2-Dinhero");
                        int escolhaDinheroOuCartao = int.Parse(Console.ReadLine());
                        //Cartão 
                        if (escolhaDinheroOuCartao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1-Credito");
                            Console.WriteLine("2-Debito");
                            int escolhaCreditoOuDebito = int.Parse(Console.ReadLine());
                            //Credito 
                            if (escolhaCreditoOuDebito == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você Gostaria De parcela em quantas Vezes:");
                                double parcelaMento = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Processando...");
                                Task.Delay(200).Wait();
                                Console.Clear();
                                double parcelas = prod.PreçoQuatro / parcelaMento;
                                Console.WriteLine($"Ficara {parcelaMento}x de {parcelas}");
                                Console.WriteLine($"Para Compar {prod.NomeProdutoQuatro} de {prod.PreçoQuatro}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                            else if (escolhaCreditoOuDebito == 2)
                            {
                                Console.WriteLine($"Para Compar {prod.NomeProdutoQuatro} de {prod.PreçoQuatro}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();



                            }
                        }
                        //Dinhero
                        else if (escolhaDinheroOuCartao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Na Compara de {prod.NomeProdutoQuatro} ficara ${prod.PreçoQuatro}");
                            Console.WriteLine("Valor dado: ");
                            double valorDado = int.Parse(Console.ReadLine());
                            double troco = valorDado - prod.PreçoQuatro;
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Console.WriteLine("Compar Aprovada");
                            Console.WriteLine("Obrigado por Compar Aqui !!");
                            Console.WriteLine($"Troco ${troco}");
                            Console.ReadLine();
                        }
                        prod.EstoqueQuatro -= 1;
                    }
                    //Produto 5
                    else if (escolhaProdutoPagamento == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual Seria a forma de Pagamento: ");
                        Console.WriteLine("1-Cartão");
                        Console.WriteLine("2-Dinhero");
                        int escolhaDinheroOuCartao = int.Parse(Console.ReadLine());
                        //Cartão 
                        if (escolhaDinheroOuCartao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1-Credito");
                            Console.WriteLine("2-Debito");
                            int escolhaCreditoOuDebito = int.Parse(Console.ReadLine());
                            //Credito 
                            if (escolhaCreditoOuDebito == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você Gostaria De parcela em quantas Vezes:");
                                double parcelaMento = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Processando...");
                                Task.Delay(200).Wait();
                                Console.Clear();
                                double parcelas = prod.PreçoCinco / parcelaMento;
                                Console.WriteLine($"Ficara {parcelaMento}x de {parcelas}");
                                Console.WriteLine($"Para Compar {prod.NomeProdutoCinco} de {prod.PreçoCinco}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();
                            }
                            else if (escolhaCreditoOuDebito == 2)
                            {
                                Console.WriteLine($"Para Compar {prod.NomeProdutoCinco} de {prod.PreçoCinco}");
                                Console.WriteLine("Incira o Cartão:");
                                Console.ReadLine();
                                Task.Delay(1000).Wait();
                                Console.WriteLine("Cartão Aprovado");
                                Task.Delay(1000).Wait();



                            }
                        }
                        //Dinhero
                        else if (escolhaDinheroOuCartao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Na Compara de {prod.NomeProdutoCinco} ficara ${prod.PreçoCinco}");
                            Console.WriteLine("Valor dado: ");
                            double valorDado = int.Parse(Console.ReadLine());
                            double troco = valorDado - prod.PreçoCinco;
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Console.WriteLine("Compar Aprovada");
                            Console.WriteLine("Obrigado por Compar Aqui !!");
                            Console.WriteLine($"Troco ${troco}");
                            Console.ReadLine();
                        }
                        prod.EstoqueCinco -= 1;
                    }
                }
                    //Atualizar Estoque
                    if (escolha == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite qual seria o Produto:");
                        Console.WriteLine(prod.ToString());
                        int escolhaEstoque = int.Parse(Console.ReadLine());
                        //Produto 1 
                        if (escolhaEstoque == 1)
                        {
                            Console.WriteLine("1-" + prod.NomeProdutoUm + "Estoque:" + prod.EstoqueUm + "\n");
                            Console.Write("Seria qual o Estoque: ");
                            int estoqueAtual = int.Parse(Console.ReadLine());
                            prod.EstoqueUm = estoqueAtual;
                        }
                        //Produto 2 
                        else if (escolhaEstoque == 2)
                        {
                            Console.WriteLine("2-" + prod.NomeProdutoDois + "Estoque:" + prod.EstoqueDois + "\n");
                            Console.Write("Seria qual o Estoque: ");
                            int estoqueAtual = int.Parse(Console.ReadLine());
                            prod.EstoqueDois = estoqueAtual;
                        }
                        //Produto 3 
                        else if (escolhaEstoque == 3)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoTrês + "Estoque:" + prod.EstoqueTrês + "\n");
                            Console.Write("Seria qual o Estoque: ");
                            int estoqueAtual = int.Parse(Console.ReadLine());
                            prod.EstoqueTrês = estoqueAtual;
                        }
                        //Produto 4
                        else if (escolhaEstoque == 4)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoQuatro + "Estoque:" + prod.EstoqueQuatro + "\n");
                            Console.Write("Seria qual o Estoque: ");
                            int estoqueAtual = int.Parse(Console.ReadLine());
                            prod.EstoqueQuatro = estoqueAtual;
                        }
                        //Produto 5
                        else if (escolhaEstoque == 5)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoCinco + "Estoque:" + prod.EstoqueCinco + "\n");
                            Console.Write("Seria qual o Estoque: ");
                            int estoqueAtual = int.Parse(Console.ReadLine());
                            prod.EstoqueCinco = estoqueAtual;
                        }
                        else
                        {
                            Console.WriteLine("Erro");
                        }
                    }

                    //Atualizar Produto
                    if (escolha == 3)
                    {

                        Console.Clear();
                        Console.WriteLine("Digite qual seria o Produto:");
                        Console.WriteLine(prod.ToString());
                        int escolhaProduto = int.Parse(Console.ReadLine());
                        //Produto 1 
                        if (escolhaProduto == 1)
                        {
                            Console.WriteLine("1-" + prod.NomeProdutoUm + "\n");
                            Console.Write("Seria qual o Nome: ");
                            string nomeAtual = Console.ReadLine();
                            prod.NomeProdutoUm = nomeAtual;
                        }
                        //Produto 2 
                        else if (escolhaProduto == 2)
                        {
                            Console.WriteLine("2-" + prod.NomeProdutoDois + "\n");
                            Console.Write("Seria qual o Nome: ");
                            string nomeAtual = Console.ReadLine();
                            prod.NomeProdutoDois = nomeAtual;
                        }
                        //Produto 3
                        else if (escolhaProduto == 3)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoTrês + "\n");
                            Console.Write("Seria qual o Nome: ");
                            string nomeAtual = Console.ReadLine();
                            prod.NomeProdutoTrês = nomeAtual;
                        }
                        //Produto 4
                        else if (escolhaProduto == 4)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoQuatro + "\n");
                            Console.Write("Seria qual o Nome: ");
                            string nomeAtual = Console.ReadLine();
                            prod.NomeProdutoQuatro = nomeAtual;
                        }
                        //Produto 5
                        else if (escolhaProduto == 5)
                        {
                            Console.WriteLine("3-" + prod.NomeProdutoCinco + "\n");
                            Console.Write("Seria qual o Nome: ");
                            string nomeAtual = Console.ReadLine();
                            prod.NomeProdutoCinco = nomeAtual;
                        }
                        else
                        {
                            Console.WriteLine("Erro");
                        }
                    }
                    //Tabela Atualizado
                    if (escolha == 4)
                    {

                        Console.Clear();
                        Console.WriteLine(prod.ToString());
                        Console.ReadLine();
                    }
                    else if (escolha == 5)
                    {
                        repetiçao = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("erro");
                        Task.Delay(200).Wait();
                        Console.Clear();
                    }



                }





            }
        }
    }
