using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
// title(eventually replace with ID), description, price, date
// create instance of Order
// get properties, return properties
// GetAll, return list, **IDispose
// GetAll, retun list of orders 
// AssignId, return Id
// FindOrder by Id, return order by Id
namespace VendorOrder.Tests {
  [TestClass]
  public class OrderTests {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order() {  
      // arrange
      Order testOrder = new Order();
      // act
      // assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}