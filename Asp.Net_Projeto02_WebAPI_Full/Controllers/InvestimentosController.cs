using Microsoft.AspNetCore.Mvc;
using Asp.Net_Projeto02_WebAPI_Full.Models;

namespace Asp.Net_Projeto02_WebAPI_Full.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvestimentosController : ControllerBase
{
    // Lista que simula um banco de dados
    private static List<ProdutoFinanceiro> _banco = new List<ProdutoFinanceiro>();

    [HttpGet]
    public ActionResult<List<ProdutoFinanceiro>> ListarTodos()
    {
        return Ok(_banco);
    }

    [HttpPost] 
    public ActionResult Criar(ProdutoFinanceiro novoProduto)
    {
        _banco.Add(novoProduto);
        return Ok("Produto cadastrado com sucesso!");
    }

    
    [HttpPut("{id}")]   // Requisição PUT para atualizar um item específico pelo ID
    public ActionResult Atualizar(int id, ProdutoFinanceiro atualizado)
    {
        // 1. Procuramos o item na lista pelo ID
        var itemExistente = _banco.FirstOrDefault(x => x.Id == id);
        
        if (itemExistente == null) 
            return NotFound("Investimento não encontrado!");

        // 2. Atualizamos os dados
        itemExistente.Nome = atualizado.Nome;
        itemExistente.Preco = atualizado.Preco;

        return Ok("Atualizado com sucesso!");
    }

    
    [HttpDelete("{id}")]    // Requisição DELETE para remover um item específico pelo ID
    public ActionResult Deletar(int id)
    {
        // 1. Procuramos o item na lista pelo ID
        var itemExistente = _banco.FirstOrDefault(x => x.Id == id);
        
        if (itemExistente == null) 
            return NotFound("ID não existe na lista!");

        // 2. Removemos o item da lista
        _banco.Remove(itemExistente);
        return Ok("Removido da sua carteira!");
    }

}
