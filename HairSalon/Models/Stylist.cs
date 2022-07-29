using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist>{};
    public int Id {get;}
    public string StylistName{get; set;}
    public List<Client> Clients{get;set;} 
    
    public Stylist(string stylistName, )
    {
      VendorName = vendorName;
     _instances.Add(this);
    Id = _instances.Count;
    Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchOid)
    {
      return _instances[searchOid-1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    
  }
}