using Microsoft.AspNetCore.Mvc;
using Asp.Net_Projeto01_WebAPI_Base.Models; // Importante para enxergar o Model

namespace Asp.Net_Projeto01_WebAPI_Base.Controllers;

[ApiController]     // Indica que essa classe é um Controller de API (faz com que o ASP.NET entenda que ela é responsável por responder a requisições HTTP)
[Route("api/[controller]")]     // Define a rota usando o nome do controller (http://localhost:5231/api/Investimentos)
public class InvestimentosController : ControllerBase
{
    // Lista que simula um banco de dados
    private static List<ProdutoFinanceiro> _bancoDeDados = new List<ProdutoFinanceiro>();

    [HttpGet]   // Indica que é uma requisição Get
    public ActionResult<List<ProdutoFinanceiro>> ListarTodos()
    {
        return Ok(_bancoDeDados);
    }

    [HttpPost]  // Indica que é uma requisição Post
    public ActionResult Criar(ProdutoFinanceiro novoProduto)
    {
        _bancoDeDados.Add(novoProduto);
        return Ok("Produto cadastrado com sucesso!");
    }
}
