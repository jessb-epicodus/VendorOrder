using System.Collections.Generic;
//name, description, list of orders
namespace VendorOrder.Models {
  public class Vendor {
    public string Name { get; set;}

    public Vendor(string name)
    {
      Name = name;
    }
  }
}