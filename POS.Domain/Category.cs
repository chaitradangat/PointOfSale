using POS.Domain.Interfaces;

namespace POS.Domain;
public class Category : IDomain
{
    public int ID { get; set; }
    public string Name { get; set; }
}
