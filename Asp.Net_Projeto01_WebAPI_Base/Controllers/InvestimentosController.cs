using Microsoft.AspNetCore.Mvc;
using Asp.Net_Projeto01_WebAPI_Base.Models; // Importante para enxergar o Model

namespace Asp.Net_Projeto01_WebAPI_Base.Controllers;

[ApiController]                  // Temos que tambem adicionar o comentario 
[Route("api/[controller]")]
public class InvestimentosController : ControllerBase
{
    // Lista que simula um banco de dados
    private static List<ProdutoFinanceiro> _bancoDeDados = new List<ProdutoFinanceiro>();

    [HttpGet]
    public ActionResult<List<ProdutoFinanceiro>> ListarTodos()
    {
        return Ok(_bancoDeDados);
    }

    [HttpPost]
    public ActionResult Criar(ProdutoFinanceiro novoProduto)
    {
        _bancoDeDados.Add(novoProduto);
        return Ok("Produto cadastrado com sucesso!");
    }
}
