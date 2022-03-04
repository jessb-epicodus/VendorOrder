using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
// name, list<order>
// create instance of vendor  X
// get properties, return properties  X
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
      Vendor testVendor = new Vendor("test");
      //Act
      //Assert
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void VendorDetails_ReturnsDetails_String()
    {
      //Arrange
      string name = "test";
      Vendor testVendor = new Vendor(name);
      //Act
      string result = testVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void ClearAllGetAll_ClearsStaticList_EmptyList() {
      //Arrange
      List<Vendor> testList = new List<Vendor> {};
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
  }
}