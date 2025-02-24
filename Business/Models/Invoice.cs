using Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Models;

public class Invoice
{
    public int Id { get; set; }

    public Project? Project { get; set; } = null!;
    public Customer? Customer { get; set; } = null!;

    public decimal Amount { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public bool IsPaid { get; set; }
}
