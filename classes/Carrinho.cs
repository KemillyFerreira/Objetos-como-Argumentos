using System;
using System.Collections.Generic;

namespace Objetos_como_Argumentos
{
    public class Carrinho
    {
        public Carrinho(float valorTotal)
        {
            this.ValorTotal = valorTotal;

        }

        public Carrinho()
        {
        }

        public float ValorTotal { get; set; }

        List<Produto> listaDeProdutos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            listaDeProdutos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            listaDeProdutos.Remove(produto);
        }

        public void MostrarProduto()
        {
            if (listaDeProdutos != null)
            {
                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Código {item.Codigo} - R${item.Preco.ToString("n2")} - Nome {item.Nome}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado");
            }
        }

        public void AlterarItem(int _codigo, Produto _produtoNovo)
        {
            listaDeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Codigo = _produtoNovo.Codigo;
        }
    }
}