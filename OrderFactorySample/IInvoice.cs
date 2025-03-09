namespace OrderFactorySample
{
    public interface IInvoice
    {
        void GenerateInvoice();
    }

    public class RegularInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Generating regular invoice.");
        }
    }
    public class SpecialInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Generating special invoice.");
        }
    }
}
