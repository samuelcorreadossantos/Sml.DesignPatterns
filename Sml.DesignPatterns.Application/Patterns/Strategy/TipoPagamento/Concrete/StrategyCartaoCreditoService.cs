using Sml.DesignPatterns.Application.Enums;
using Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Interfaces;

namespace Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Concrete
{
    public class StrategyCartaoCreditoService : IPagamentoStrategy
    {
        public async Task<string> PagarAsync(decimal valor, int id)
        {
            return await Task.FromResult("Pagar com cartão de crédito.");
        }

        public bool Selecionar(ETipoPagamento tipoPagamento) => tipoPagamento.Equals(ETipoPagamento.CartaoCredito);
    }
}