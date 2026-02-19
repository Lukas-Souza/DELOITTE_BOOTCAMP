using Dtos;
using Domain;
namespace Models
{
       public class Equipaments
    {
        public Equipaments(){}
        public int Id {get;private set;}
        public decimal Horimetro {get;private set;}
        public string Tipo {get;private set;} = string.Empty;
        public string Codigo {get;private set;}= string.Empty;
        public string Modelo {get;private set;}= string.Empty;
        public string LocalizacaoAtual {get;private set;} = string.Empty;
        public string StatusOperacional {get;private set;} = string.Empty;
        public DateTime DataAquisicao {get;private set;}
        public Equipaments(EquipamentsDto _dto)
        {
            bool IsNullCodigo = string.IsNullOrWhiteSpace(_dto.Codigo);
            bool IsNullTipo = string.IsNullOrWhiteSpace(_dto.Tipo);
            bool IsNullModelo = string.IsNullOrWhiteSpace(_dto.Modelo);
            bool IsNullLocalizacao = string.IsNullOrWhiteSpace(_dto.LocalizacaoAtual);
            bool IsNullStatus = string.IsNullOrWhiteSpace(_dto.StatusOperacional);

            bool IsNullObject = _dto.DataAquisicao == null;
            bool IsNullString = IsNullCodigo || IsNullTipo || IsNullModelo || IsNullLocalizacao || IsNullStatus;


            bool IsNegativeHorimetro = _dto.Horimetro <= 0;
            bool IsvalueValitatedStatus = !Enum.TryParse<StatusOperacional>(_dto.StatusOperacional, out _);
            bool IsValidation = IsNegativeHorimetro || IsNullCodigo || IsvalueValitatedStatus || IsNullObject || IsNullString;

            if (!IsValidation)
            {
                 
                this.Horimetro = _dto.Horimetro; 
                this.Tipo = _dto.Tipo;
                this.Codigo = _dto.Codigo;
                this.Modelo = _dto.Modelo;
                this.LocalizacaoAtual = _dto.LocalizacaoAtual;
                this.StatusOperacional = _dto.StatusOperacional;
                this.DataAquisicao = _dto.DataAquisicao;
            }else
            {
                throw new ArgumentException("Os dados fornecidos são invalidos..");
            }
        }


        public void Update(UpdateEquipamentos _dto)
        {
            bool IsNullCodigo = string.IsNullOrWhiteSpace(_dto.Codigo);
            bool IsNullTipo = string.IsNullOrWhiteSpace(_dto.Tipo);
            bool IsNullModelo = string.IsNullOrWhiteSpace(_dto.Modelo);
            bool IsNullLocalizacao = string.IsNullOrWhiteSpace(_dto.LocalizacaoAtual);
            bool IsNullStatus = string.IsNullOrWhiteSpace(_dto.StatusOperacional);

            bool IsNullObject = _dto.DataAquisicao == null;
            bool IsNullString = IsNullCodigo || IsNullTipo || IsNullModelo || IsNullLocalizacao || IsNullStatus;


            bool IsNegativeHorimetro = _dto.Horimetro <= 0;
            bool IsvalueValitatedStatus = !Enum.TryParse<StatusOperacional>(_dto.StatusOperacional, out _);
            bool IsValidation = IsNegativeHorimetro || IsNullCodigo || IsvalueValitatedStatus || IsNullObject || IsNullString;

            if (!IsValidation)
            {
                 
                this.Horimetro = _dto.Horimetro; 
                this.Tipo = _dto.Tipo;
                this.Codigo = _dto.Codigo;
                this.Modelo = _dto.Modelo;
                this.LocalizacaoAtual = _dto.LocalizacaoAtual;
                this.StatusOperacional = _dto.StatusOperacional;
                this.DataAquisicao = _dto.DataAquisicao;
            }else
            {
                throw new ArgumentException("Os dados fornecidos são invalidos..");
            }
        }


    }
}