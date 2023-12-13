using Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Concrete;
using Sml.DesignPatterns.Application.Patterns.Strategy.TipoPagamento.Interfaces;
using Sml.DesignPatterns.Application.Services.Concrete;
using Sml.DesignPatterns.Application.Services.Interfaces;

namespace Sml.DesignPatterns.Api.Extensions
{
    public static class PatternStrategyExtension
    {
        public static void ConfigureStrategyPatterns(this IServiceCollection services)
        {
            services.AddTransient<StrategyBoletoService>();
            services.AddTransient<StrategyCartaoCreditoService>();
            services.AddTransient<StrategyCartaoDebitoService>();
            services.AddTransient<StrategyPixService>();

            services.AddScoped<IPagamentoService>(
                _ =>
                new TipoPagamentoService
                (
                    new List<IPagamentoStrategy>
                    {
                        _.GetRequiredService<StrategyBoletoService>(),
                        _.GetRequiredService<StrategyCartaoCreditoService>(),
                        _.GetRequiredService<StrategyCartaoDebitoService>(),
                        _.GetRequiredService<StrategyPixService>(),
                    }
                )
            );
        }
    }
}