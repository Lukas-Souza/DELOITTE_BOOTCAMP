using System;
using System.Net.Sockets;
using Data;
namespace ServicesCRUD
{

    public class Services
    {        
        public Stock stock = new Stock();
        public bool CreateProductInList(int stockQuantity_, double price_, string name_)
        {
            try
            {
                if( stockQuantity_ >=1 && price_ >=1 )
                {
                    stock.Sotck.Add(new Produto(stockQuantity_, price_, name_));
                    return true;
                }
                else
                {
                    return false;
                }  
            }
            catch
            {
                return false;
            }
            
        }

        public bool RemoveProductInList(string Name)
        {
            foreach (var produto in stock.Sotck)
            {
                if(produto.Name.ToLower() == Name.ToLower())
                {
                    stock.Sotck.Remove(produto);
                    return true;
                }
            }
            return false;
    
        }
    }
}