using System;

namespace Objetos_como_Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1, "Mouse Razer 3.5", 300);
            Produto produto2 = new Produto(2, "HeadSet Chroma 7.1", 500);
            Produto produto3 = new Produto(3, "Mouse pad XPTO", 120);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);

            Produto produtoNovo = new Produto();
            produtoNovo.Codigo = 20;
            produtoNovo.Nome = "Fone com microfone Chroma 7.1";
            produtoNovo.Preco = 600;

            carrinho.AlterarItem(2, produtoNovo);

            carrinho.MostrarProduto();
        }
    }
}
