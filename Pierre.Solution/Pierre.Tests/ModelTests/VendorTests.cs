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
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name);

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
      string name02 = "Trevett's Cafe";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectAlbum_Album()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Album newAlbum1 = new Album(name01);
    //   Album newAlbum2 = new Album(name02);

    //   //Act
    //   Album result = Album.Find(2);

    //   //Assert
    //   Assert.AreEqual(newAlbum2, result);
    // }

    // [TestMethod]
    // public void AddItem_AssociatesItemWithCategory_ItemList()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Song newSong = new Song(description);
    //   List<Song> newList = new List<Song> { newSong };
    //   string name = "Work";
    //   Album newAlbum = new Album(name);
    //   newAlbum.AddSong(newSong);

    //   //Act
    //   List<Song> result = newAlbum.Songs;

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}
