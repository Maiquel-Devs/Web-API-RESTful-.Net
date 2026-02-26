namespace Asp.Net_Projeto01_WebAPI_Base.Models;

public class ProdutoFinanceiro
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string Tipo { get; set; } = "Ação"; // Ex: Cripto, FII, ETF
}
