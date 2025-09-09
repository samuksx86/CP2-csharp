// Program.cs
using CheckPoint.Database;
using CheckPoint.Model;
using System;

namespace FiapCheckpoint2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checkpoint FIAP - EF Core Code First");

            using var db = new ConfigurationDb();

            Console.WriteLine("DbContext ok. Use os comandos de migration para gerar o banco.");
            
            // Inserir dados de exemplo
            Console.WriteLine("Inserindo dados de exemplo...");
            
            // Inserir 10 produtos
            var produtos = new[]
            {
                new RM99134_Produtos { NmProduto = "Notebook Dell Inspiron", Preco = 2500.00m },
                new RM99134_Produtos { NmProduto = "Mouse Logitech", Preco = 45.90m },
                new RM99134_Produtos { NmProduto = "Teclado Mecânico", Preco = 120.00m },
                new RM99134_Produtos { NmProduto = "Monitor 24\"", Preco = 800.00m },
                new RM99134_Produtos { NmProduto = "SSD 500GB", Preco = 350.00m },
                new RM99134_Produtos { NmProduto = "Memória RAM 16GB", Preco = 280.00m },
                new RM99134_Produtos { NmProduto = "Placa de Vídeo RTX 3060", Preco = 1800.00m },
                new RM99134_Produtos { NmProduto = "Fonte 600W", Preco = 200.00m },
                new RM99134_Produtos { NmProduto = "Gabinete ATX", Preco = 150.00m },
                new RM99134_Produtos { NmProduto = "Webcam HD", Preco = 95.00m }
            };

            db.Produtos.AddRange(produtos);

            // Inserir 10 pedidos
            var pedidos = new[]
            {
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-10), ValorTotal = 2500.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-9), ValorTotal = 165.90m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-8), ValorTotal = 920.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-7), ValorTotal = 630.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-6), ValorTotal = 2080.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-5), ValorTotal = 350.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-4), ValorTotal = 95.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-3), ValorTotal = 1200.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-2), ValorTotal = 450.00m },
                new RM99134_Pedido { DtPedido = DateTime.Now.AddDays(-1), ValorTotal = 1800.00m }
            };

            db.Pedido.AddRange(pedidos);

            // Inserir 10 fornecedores
            var fornecedores = new[]
            {
                new RM99134_Fornecedor { nrCep = "01234567", dsEndereco = "Rua das Flores, 123", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "12345678", dsEndereco = "Av. Paulista, 456", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "23456789", dsEndereco = "Rua Augusta, 789", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "34567890", dsEndereco = "Av. Faria Lima, 321", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "45678901", dsEndereco = "Rua Oscar Freire, 654", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "56789012", dsEndereco = "Av. Rebouças, 987", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "67890123", dsEndereco = "Rua Bela Cintra, 147", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "78901234", dsEndereco = "Av. Consolação, 258", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "89012345", dsEndereco = "Rua Haddock Lobo, 369", Estado = "SP", Cidade = "São Paulo" },
                new RM99134_Fornecedor { nrCep = "90123456", dsEndereco = "Av. 9 de Julho, 741", Estado = "SP", Cidade = "São Paulo" }
            };

            db.Fornecedores.AddRange(fornecedores);

            db.SaveChanges();
            Console.WriteLine("Dados inseridos com sucesso!");
            Console.WriteLine($"Produtos inseridos: {produtos.Length}");
            Console.WriteLine($"Pedidos inseridos: {pedidos.Length}");
            Console.WriteLine($"Fornecedores inseridos: {fornecedores.Length}");
        }
    }
}
