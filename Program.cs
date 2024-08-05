internal class Program
{
    private static void Main(string[] args)
    {
       var stock = new Stock("Amazon");
        stock.Price = 100;
        Console.WriteLine($"stock before changing: ${stock.Price }");
        stock.ChangesStockPriceBy(0.05m);
        Console.WriteLine($"stock after changing :{stock.Price}");
    }
}
public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
public class Stock
{
    private string name;
    private decimal price;
    public event StockPriceChangeHandler OnPriceChanged   ;
    public string   Name => this.name;
    public decimal Price {  get =>  this.price; set => this.price=value; }
    public Stock(string stockname)
    {
        this.name = stockname;
    }
    public void ChangesStockPriceBy(decimal percent)
    {
        this.price += Math.Round(this.price*percent,2 ) ;
    }
}