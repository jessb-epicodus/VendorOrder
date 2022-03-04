using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
// name, list<order>
// create instance of vendor
// get properties, return properties
// GetAll, return list, **IDispose
// GetAll, retun list of Vendor
// AssignId, return Id
// Find vendor by Id, return Vendor by Id
// stretch find vendor by name
namespace VendorOrder.Tests {
  [TestClass]
  public class VendorTests {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor() {  
      //Arrange
      Vendor testVendor = new Vendor();
      //Act
      //Assert
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}