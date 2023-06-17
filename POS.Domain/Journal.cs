using System;
using POS.Domain.Interfaces;


namespace POS.Domain;
public class Journal : IDomain
{
    public int ID {get; set;}

    public DateTime Date {get; set;}
}
