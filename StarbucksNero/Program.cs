// See https://aka.ms/new-console-template for more information

using StarbucksNero.Abstract;
using StarbucksNero.Adapters;
using StarbucksNero.Concrete;

namespace StarbucksNero
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            
        }
    }
}
