using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        // Add
        //   - Check the first index after push for equal values (what is in there vs. what was pushed)
        //   - Check the second index after a second push for equal values (what is in there vs. what was pushed)
        //   - Check the first index after a second push for equal values (what is in there vs. what was pushed)
        //   - Check array length (count) after a push that brings the length over it's starting limit (what the array length was vs what the array length is after)
        //   - Check type of value after push? (IsInstanceOfType)
        //   - Check the first index after pushing 10 items to the array (what is in there vs. what was pushed)

        [TestMethod]
        private static void AddMethod_FirstIndexCheckAfterFirstPush_isTrue()
        {
            // Arrange
            CustomList newList = new CustomList();
            int expectedResult = 4;

            // Act
            newList.Add(4);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        private static void AddMethod_SecondIndexCheckAfterSecondPush_isTrue()
        {
            // Arrange
            CustomList newList = new CustomList();
            int expectedResult = 6;

            // Act
            newList.Add(4);
            newList.Add(6);

            // Assert
            Assert.AreEqual(expectedResult, newList[1]);
        }

        [TestMethod]
        private static void AddMethod_FirstIndexCheckAfterSecondPush_isTrue()
        {
            // Arrange
            CustomList newList = new CustomList();
            int expectedResult = 4;

            // Act
            newList.Add(4);
            newList.Add(6);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        private static void AddMethod_ListLengthCheckAfterLimitIsHit_isNotEqualToo()
        {
            // Arrange
            CustomList newList = new CustomList();
            int expectedResult = 5;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);

            // Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }

        [TestMethod]
        private static void AddMethod_FirstIndexTypeCheckAfterMultiplePushes_isTrue()
        {
            // Arrange
            CustomList newList = new CustomList();
            int expectedResult = 1;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(6);
            newList.Add(7);
            newList.Add(8);
            newList.Add(9);
            newList.Add(10);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        // Remove
        //   - Check the first index after remove for null value (or 0, whatever it gets set to)
        //   - Check the second index after the first value is removed to see if the value is equal to third index beforehand
        //   - Check the first index value after the second index value is removed to see if it is equal
        //   - Check list count after removing an item
        //   - Check list count after removing 10 items
        //   - Check the index values after removing 3 items

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        // ToString
        //   - 
        //   - 
        //   - 
        //   - 
        //   - 

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        // Zip
        //   - 
        //   - 
        //   - 
        //   - 
        //   - 

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        // Overload + Operator
        //   - 
        //   - 
        //   - 
        //   - 
        //   - 

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        // Overload - Operator
        //   - 
        //   - 
        //   - 
        //   - 
        //   - 

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        private static void nameHere()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
