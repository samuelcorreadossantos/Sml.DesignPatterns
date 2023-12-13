using System.Text.Json.Serialization;
using Sml.DesignPatterns.Application.Enums;

namespace Sml.DesignPatterns.Application.Models.Pagamento
{
    public class PagamentoModel
    {
        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }

        [JsonPropertyName("tipoPagamento")]
        public ETipoPagamento TipoPagamento { get; set; }
    }
}