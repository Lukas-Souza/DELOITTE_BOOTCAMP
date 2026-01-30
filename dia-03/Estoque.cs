using System.Buffers;
using System.Data.Common;

namespace Objetos
{
    public class Estoque
    {
        private int Id ;
        private int ProducaoId ;
        private decimal Quantidade ;
        private string Local ;
        

        private bool adicionarMinerio(bool key)
        {
            if (!key)
            {
              return false;  
            } 
            else  {
                Quantidade +=1;
                return true;
            }

        }
        public void montarEstoque(int id, int producao_, decimal quantidade_, string local_)
        {
            bool var =  quantidade_ <0 && id < 0;
            bool var2 =  producao_ < 0 && !string.IsNullOrWhiteSpace(local_);
            bool IsValuention = var && var2;
            if( IsValuention)
            {

                Id = id;
                ProducaoId = producao_;
                Quantidade = quantidade_;
                Local = local_;    
                
            }
        }
    
    }
}