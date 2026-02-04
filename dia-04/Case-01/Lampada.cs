namespace LampadaSevice
{
public class Lampada
{
    private bool StatusLampada = false;
    public string LuzLampada  {get; private set;}
    private int Count= 0;
    public bool ClickInterrruptor()
    {
        if (this.StatusLampada == true) {
            StatusLampada = false;
            Count +=1;
            return StatusLampada;
            }
            else
            {
              StatusLampada = true;
                Count +=1;
            return StatusLampada;
   
            } 
    }
    public void criarLampada(string luzLampada_)
        {
            LuzLampada = luzLampada_;
        }

public bool isQueimou()
        {
         if (Count > 50) return true;
         else return false;   
        }
}    
}
