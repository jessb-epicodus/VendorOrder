using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
// title(eventually replace with ID), description, price, date
// create instance of Order  X
// get properties, return properties  X
// GetAll, return list, **IDispose  X
// GetAll, retun list of orders  X
// AssignId, return Id  X
// FindOrder by Id, return order by Id  X
namespace VendorOrder.Tests {
  [TestClass]
  public class OrderTests : IDisposable {
    public void Dispose() {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order() {  
      //Arrange
      Order testOrder = new Order("title", "description", 100, "date");
      //Act
      //Assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void OrderDetails_ReturnsOrderDetail_OrderDetail() {
      //Arrange
      string title = "title";
      string description = "description";
      int price = 100;
      string date = "date";
      Order testOrder = new Order(title, description, price, date);
      //Act
      string result = testOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void ClearAllGetAll_ClearStaticList_OrderList() {
      //Arrange
      List<Order> testList = new List<Order> {};
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList() {
      //Arrange
      string title = "title";
      string description = "description";
      int price = 100;
      string date = "date";
      Order testOrder1 = new Order(title, description, price, date);
      Order testOrder2 = new Order(title, description, price, date);
      List<Order> testList = new List<Order> { testOrder1, testOrder2 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void AssignId_AssignIdToIstantiatedOrder_Int() {
      //Arrange
      string title = "title";
      string description = "description";
      int price = 100;
      string date = "date";
      Order testOrder = new Order(title, description, price, date);
      //Act
      int result = testOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order() {
      //Arrange
      string title = "title";
      string description = "description";
      int price = 100;
      string date = "date";
      Order testOrder1 = new Order(title, description, price, date);
      Order testOrder2 = new Order(title, description, price, date);
      //Act
      Order result = Order.Find(2);
      //Assert
      Assert.AreEqual(testOrder2, result);
    }
  }
}