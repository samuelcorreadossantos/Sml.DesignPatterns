using Sml.DesignPatterns.Application.Models.Pagamento;
using Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Interfaces;
using Sml.DesignPatterns.Application.Services.Interfaces;

namespace Sml.DesignPatterns.Application.Services.Concrete
{
    public class TipoPagamentoService : IPagamentoService
    {
        private readonly IEnumerable<IPagamentoStrategy> _strategies;

        public TipoPagamentoService(IEnumerable<IPagamentoStrategy> strategies)
        {
            _strategies = strategies;
        }

        public async Task<string> ExecutarAsync(PagamentoModel pagamentoModel, int id)
        {
            var strategy = _strategies.FirstOrDefault(_ => _.Selecionar(pagamentoModel.TipoPagamento));

            if (strategy == null)
            {
                throw new Exception("Tipo de pagamento não reconhecido.");
            }

            return await strategy.PagarAsync(pagamentoModel.Valor, id);
        }
    }
}