using System;
namespace Models
{
    public class LotMinerio
    {
        public int IdLote {get; private set;}
        public string IdMineradora {get; private set;}
        public double Teor {get;private  set;}
        public double PesoQuantidade {get;private  set;} 
        public double ValorPKilo {get;private set;}
        public string? UnidadeDeMedidaPeso {get;private  set;}
        public string? TipoMinerio {get;private set;}
        public string? Status {get;private set;}
        public DateTime DataExtracao {get;private set;}
        public LotMinerio(

            // PARAM 
            double _Teor,
            double _PesoQuantidade,
            double _ValorPKilo,
            string _UnidadeDeMedida,
            string _TipoMinerio,
            string _Status,
            string _IdMineradora
        )
        {
            // Program
            bool IsNullUnidade = string.IsNullOrWhiteSpace(_UnidadeDeMedida);
            bool IsNullTipo = string.IsNullOrWhiteSpace(_TipoMinerio);
            bool IsNullStatus = string.IsNullOrWhiteSpace(_Status);
            bool IsNullIdMineradora = string.IsNullOrWhiteSpace(_IdMineradora);

            bool IsNegativoTeor = _Teor <= 0;
            bool IsNegativoPesoQuantidade = _PesoQuantidade <=0;
            bool IsNegativoValorPKilon = _ValorPKilo <=0;

            bool IsNullString = IsNullUnidade && IsNullTipo && IsNullStatus && IsNullIdMineradora;
            bool IsNullDouble = IsNegativoValorPKilon && IsNegativoPesoQuantidade && IsNegativoTeor;

            bool IsValidation = IsNullString && IsNullDouble;

            if (!IsValidation)
            {
                this.Teor = _Teor;
                this.PesoQuantidade = _PesoQuantidade;
                this.ValorPKilo = _ValorPKilo;
                this.UnidadeDeMedidaPeso = _UnidadeDeMedida;
                this.TipoMinerio = _TipoMinerio;
                this.Status = _Status;
                this.IdMineradora = _IdMineradora;
                this.DataExtracao = DateTime.UtcNow;

            }
            else
            {
                return;
            }
        }
        
        // Para ficar visivel para o EF
        protected LotMinerio() { }
    }
    
}