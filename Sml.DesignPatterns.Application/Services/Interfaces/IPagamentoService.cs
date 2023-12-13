using Sml.DesignPatterns.Application.Models.Pagamento;

namespace Sml.DesignPatterns.Application.Services.Interfaces
{
    public interface IPagamentoService
    {
        Task<string> ExecutarAsync(PagamentoModel pagamentoModel, int id);
    }
}