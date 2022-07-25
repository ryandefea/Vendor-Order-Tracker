using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Hotdogs";
      double price = 5;

      //Act
      Order newOrder = new Order(description, price);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Hotdogs";
      double price = 5;

      //Act
      Order newOrder = new Order(description, price);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Hotdogs";
      double price = 5;
      Order newOrder = new Order(description, price);

      //Act
      string updatedDescription = "Buns";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "Hotdogs";
      double price01 = 5;
      string description02 = "Buns";
      double price02 = 3; 
      Order newOrder1 = new Order(description01, price01);
      Order newOrder2 = new Order(description02, price02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturn_Int()
    {
      string description = "Hotdogs";
      double price = 5; 
      Order newOrder = new Order(description, price);
      int result = newOrder.Id;
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Order()
    {
      //Arrange
      string description01 = "Hotdogs";
      double price01 = 5;
      string description02 = "Buns";
      double price02 = 3; 
      Order newOrder1 = new Order(description01, price01);
      Order newOrder2 = new Order(description02, price02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}