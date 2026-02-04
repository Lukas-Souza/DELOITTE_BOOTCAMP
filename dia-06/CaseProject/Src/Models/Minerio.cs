namespace Models
{
    public class Minerio
    {
           public int Id { get; private set; }
           public string? CodigoMineradora {get; private set;}
           public string? CodElementoQuimico {get; private set;}
           public double KiloGrama {get; private set;}
            public string? CodLote{get; private set;}
            public double ValorPKilo {get; private set;}
            public DateTime DataMineracao {get; private set;}
    }
}