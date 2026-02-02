using System;
using System.Buffers;
using System.Data.Common;
using System.Dynamic;
using System.Reflection.Metadata;

public class CCInformation
{

    private bool IsSpecial = false;
    private string number;
    decimal Saldo =0;
    decimal Limite= 0;

    public CCInformation(bool PIsSpecial, string PNumber, int PLimite,decimal PSaldo )
    {
        bool isConditionLimite = PLimite >= 0;
        bool isConditionSaldo = PSaldo >= 0;

        if(isConditionLimite && isConditionSaldo)
        {
            Saldo = PSaldo;
            number = PNumber;
            Limite = PLimite;
            IsSpecial = PIsSpecial;
        }
    }

    public bool SacarValor(decimal PSaldo)
    {
        if (PSaldo < Saldo)
        {
          Saldo -= PSaldo;
          return true;  
        }
        else
        {
            if( IsSpecial)
            {
              if (PSaldo <= Limite)
                {
                    Limite -= PSaldo;
                    return true;
                }   
            }
            return false;
        }

    }

    public bool DepositarSaldo( decimal PSaldo)
    {
        if (PSaldo >0)
        {
            Saldo += PSaldo;
            Console.WriteLine(Saldo);
            return true;
        }
        else
        {
            
            return false;
        }
        
    }
    public decimal GetSaldo()
    {
        return Saldo;
    }
        public string GetNUmber()
    {
        return this.number;
    }
        public decimal GetLimite()
    {
        return this.Limite;
    }
    public bool GetCategory()
    {
        return this.IsSpecial;
    }

}
    
