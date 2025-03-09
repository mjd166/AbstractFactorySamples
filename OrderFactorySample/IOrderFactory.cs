namespace OrderFactorySample
{
    public interface IOrderFactory
    {
        IInvoice CreateInvoice();
        IReceipt CreateReceipt();
    }

    public class RegularOrderFactory : IOrderFactory
    {
        public IInvoice CreateInvoice() => new RegularInvoice();

        public IReceipt CreateReceipt() => new RegularReceipt();
    }

    public class SpecialOrderFactory : IOrderFactory
    {
        public IInvoice CreateInvoice() => new SpecialInvoice();

        public IReceipt CreateReceipt() => new SpecialReceipt();
    }

}
