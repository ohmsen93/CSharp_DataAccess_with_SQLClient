namespace CSharp_DataAccess_with_SQLClient.Models;

public class Invoice
{
    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string BillingAddress { get; set; }
    public string BillingCity { get; set;}
    public string BillingState { get; set;}
    public string BillingPostalCode { get; set; }

    public double Total { get; set; }
}