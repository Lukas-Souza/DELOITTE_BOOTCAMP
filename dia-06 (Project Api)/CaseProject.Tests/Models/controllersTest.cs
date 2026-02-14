using CaseProject;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Models;
using Xunit;
using CaseProject.Controlles;
using MinhaApi.Data;
namespace ControllersTest
{
    public class controllersTest
    {
        [Fact]
        public async Task CreateNewRegsitre()
        {

            // ================================================+
            // | Verificar se o objeto (hentidade) foi criada
            // ================================================+
            RequireLotMinerioDto requireLotMinerioDto = new RequireLotMinerioDto
            {
                Teor = 2.8,
                PesoQuantidade = 5,
                ValorPKilo = 2.5,
                UnidadeDeMedidaPeso = "TON",
                TipoMinerio = "OURO",
                Status = "CANCELADO",
                IdMineradora = "TS-007"
            };
            
            var Controllers = new MinerioController(AppDbContext);

            // //| VERIFICAR SE O OBJETO DE RETORNO È IGUAL A OBBJETO DE RESPOSTA
            // Assert.Equal(ObjetctElementTest.idMineradora, responseObeject.IdMineradora);
            // Assert.Equal(ObjetctElementTest.teor, responseObeject.Teor);
            // Assert.Equal(ObjetctElementTest.pesoQuantidade, responseObeject.PesoQuantidade);
            // Assert.Equal(ObjetctElementTest.valorPKilo, responseObeject.ValorPKilo);
            // Assert.Equal(ObjetctElementTest.unidadeMedida.ToUpper(), responseObeject.UnidadeDeMedidaPeso);
            // Assert.Equal(ObjetctElementTest.tipoMinerio, responseObeject.TipoMinerio);
            // Assert.Equal(ObjetctElementTest.status, responseObeject.Status);


        }
        
    }
}