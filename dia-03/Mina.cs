using System.Collections.Specialized;
using System.Dynamic;

namespace Objetos
{
public class mina
{
    private string? Codigo;
    private string? Nome;
    private decimal? Capaciadde; 
    private Minerio extrairMinerio()
    {
        return new Minerio(); 
    }
    public Minerio acessarMina(bool isGestor)
        {
            if(!isGestor) return this.extrairMinerio();
            else return null;
        }
    public string getName()
        {
            return this.Nome;
        }
    public string getCodigo()
        {
            return this.Codigo;
        }
        public decimal getCapacidade()
        {
            // CAST
            return (decimal)this.Capaciadde;
        }
}
}