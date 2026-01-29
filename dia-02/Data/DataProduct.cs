namespace Data
{
    public class Produto
{
    public string Name { get;  private set;}
    public double  Price { get; private set; }
    public int StockQuantity {get; private set;}
    public Produto( int stockQuantity_, double price_, string name_)
    {
        Name = name_;
        Price = price_;
        StockQuantity = stockQuantity_;
    }
}
}