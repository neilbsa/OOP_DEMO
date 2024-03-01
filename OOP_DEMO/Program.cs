// See https://aka.ms/new-console-template for more information

using OOP_DEMO;

Generics<RequestForPayment> raps = new Generics<RequestForPayment>();



raps.Create(new RequestForPayment()
{
     CompanyName = "CIVIC",

       RapsReference = "RAPS-001",
      
       

});



raps.Create(new RequestForPayment()
{
    CompanyName = "CIVIC",

    RapsReference = "RAPS-001",



});

raps.Create(new RequestForPayment()
{
    CompanyName = "CIVIC",

    RapsReference = "RAPS-001",



});


raps.Create(new RequestForPayment()
{
    CompanyName = "CIVIC",
  
    RapsReference = "RAPS-001",



});



foreach (var payment in raps.Read())
{
    Console.WriteLine($"Id { payment.Id } REFERENCE: {payment.RapsReference}");
}






Generics<Invoice> Invoices = new Generics<Invoice>();

Invoices.Create(new Invoice()
{
    CompanyName = "CIVIC",
  
    InvoiceReference = "INV-001",



});



Invoices.Create(new Invoice()
{
    CompanyName = "CIVIC",

    InvoiceReference = "INV-001",



});


Invoices.Create(new Invoice()
{
    CompanyName = "CIVIC",

    InvoiceReference = "INV-001",



});


Invoices.Create(new Invoice()
{
    CompanyName = "CIVIC",

    InvoiceReference = "INV-001",



});


foreach (var payment in Invoices.Read())
{
    Console.WriteLine($"Id {payment.Id} REFERENCE: {payment.InvoiceReference}");

}
