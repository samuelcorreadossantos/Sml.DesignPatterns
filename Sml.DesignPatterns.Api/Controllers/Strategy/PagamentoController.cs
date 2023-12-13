using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Sml.DesignPatterns.Application.Models.Pagamento;
using Sml.DesignPatterns.Application.Services.Interfaces;

namespace Sml.DesignPatterns.Api.Controllers.Strategy
{
    [ApiController]
    [Route("patterns/strategy/cases/pagamento")]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutAsync([FromBody] PagamentoModel pagamentoModel, int id)
        {
            var @return = await _pagamentoService.ExecutarAsync(pagamentoModel, id);

            return Ok(JsonSerializer.Serialize(@return));
        }
    }
}