// // Create
using aula12_ef_continuacao.Data.Repositories;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
var db = new DataContext();

        var fornecedorRepository = new FornecedorRepository(db);
        var produtoRepository = new ProdutoRepository(db);
        var compraRepository = new CompraRepository(db);
        var estoqueRepository = new EstoqueRepository(db);

// Criar e salvar fornecedores
var fornecedor = new Fornecedor { Id = 5, Nome = "Arroz", CNPJ = "987654321", Telefone = "123457789" };
fornecedorRepository.Save(fornecedor);

// Criar e salvar produtos
var produto = new Produto { Id = 5, Nome = "Arroz", Preco = 15, Quantidade = 10 };
produtoRepository.Save(produto);

// Criar e salvar compras
var compra = new Compra { Id = 5, Produto = "Feijão", Quantidade = 10, Fornecedor = "João Frango", Data = DateTime.Now.ToString() };
compraRepository.Save(compra);

// Adicionar Estoque
var estoque = new Estoque { Id = 2, Produto = "Produto3", Quantidade = 15 };
estoqueRepository.Save(estoque);


Console.WriteLine("Dados populados no banco de dados com sucesso!");


  
      
