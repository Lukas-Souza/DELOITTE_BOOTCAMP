using LampadaSevice;
public class Program
{
    public static void Main()
    {
        Lampada lampada = new Lampada();
       lampada.criarLampada("Amarelo");
        while (true)
        {
            string Key = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(Key))
            {
                if (lampada.isQueimou())
                {
                  Console.WriteLine("QUEEEIIMOOU"); 
                  break; 
                } 
            else
            {
             
            if(lampada.ClickInterrruptor()) Console.WriteLine("LIGADA..");
            else Console.WriteLine("DESLIGA...");
                  
            }
            }
        }
    }
}