using Sml.DesignPatterns.Application.Enums;

namespace Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Interfaces
{
    public interface IPagamentoStrategy
    {
        Task<string> PagarAsync(decimal valor, int id);

        bool Selecionar(ETipoPagamento tipoPagamento);
    }
}