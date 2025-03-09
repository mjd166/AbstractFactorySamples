namespace OrderFactorySample
{
    public interface IReceipt
    {
        void GenerateReciept();
    }

    public class RegularReceipt : IReceipt
    {
        public void GenerateReciept()
        {
            Console.WriteLine("Generating regular receipt");
        }
    }
    public class SpecialReceipt : IReceipt
    {
        public void GenerateReciept()
        {
            Console.WriteLine("Generating special receipt");
        }
    }

}
