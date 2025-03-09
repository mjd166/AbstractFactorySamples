using OrderFactorySample;

Console.WriteLine("--Regualr Order--");

IOrderFactory regualrOrder = new RegularOrderFactory();
var regualrInvoice= regualrOrder.CreateInvoice();
var regularReceipt=regualrOrder.CreateReceipt();
regualrInvoice.GenerateInvoice();
regularReceipt.GenerateReciept();

Console.WriteLine("--Special Order--");

IOrderFactory specialOrder= new  SpecialOrderFactory();
var specialInvoice=specialOrder.CreateInvoice();
var specialReceipt=specialOrder.CreateReceipt();
specialInvoice.GenerateInvoice();
specialReceipt.GenerateReciept();
