using POS.Domain.Interfaces;

namespace POS.Domain;
public class SKU : IDomain
{
    public int ID { get; set; }

    public string SKUName { get; set; }

    public string SKULocalName { get; set; }

    public string Locale {get;set;}

    public bool Edible { get; set; }
}
