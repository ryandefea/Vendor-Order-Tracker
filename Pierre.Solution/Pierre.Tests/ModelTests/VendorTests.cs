using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie", "Suzie's Donuts");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Suzie";
      string details = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, details);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string details = "Test Details";
      Vendor newVendor = new Vendor(name, details);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Suzie's Cafe";
      string details01 = "Suzie Detail";
      string name02 = "Trevett's Cafe";
      string details02 = "Trevett's Detail";
      Vendor newVendor1 = new Vendor(name01, details01);
      Vendor newVendor2 = new Vendor(name02, details02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Suzie's Cafe";
      string details01 = "Suzie Detail";
      string name02 = "Trevett's Cafe";
      string details02 = "Trevett's Detail";
      Vendor newVendor1 = new Vendor(name01, details01);
      Vendor newVendor2 = new Vendor(name02, details02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string description = "Hotdogs";
      double price = 5;
      string title = "Suzie's Hotdogs";
      Order newOrder = new Order(description, price, title);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzie's Cafe";
      string details = "Suzie Detail";
      Vendor newVendor = new Vendor(name, details);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
