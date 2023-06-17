using POS.Domain.Interfaces;

namespace POS.Domain;
public class Packaging : IDomain
{
    public int ID { get; set; }
    public string Type{get; set; }
    public decimal Quantity{get; set; }
}
