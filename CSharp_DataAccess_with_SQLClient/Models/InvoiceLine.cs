namespace CSharp_DataAccess_with_SQLClient.Models;

public class InvoiceLine
{
    public int InvoiceLineId { get; set; }

    public int InvoiceId { get; set; }

    public int TrackId { get; set; }

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }
}