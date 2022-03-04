using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
// title(eventually replace with ID), description, price, date
// create instance of Order  X
// get properties, return properties  X
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
      Order testOrder = new Order("title", "description", 100, "date");
      // act
      // assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void OrderDetails_ReturnsOrderDetail_OrderDetail() {
      //Arrange
      string title = "title";
      // string description = "description";
      // int price = 100;
      // string date = "date";
      Order testOrder = new Order("title", "description", 100, "date");
      //Act
      string result = testOrder.Title;
      //Assert
      Assert.AreEqual(title, "title");
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> testOrder = new List<Order> { };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(testOrder, result);
    }
  }
}