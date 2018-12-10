﻿using System;
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
        public void AddMethod_FirstIndexCheckAfterFirstPush_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 4;

            // Act
            newList.Add(4);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        public void AddMethod_SecondIndexCheckAfterSecondPush_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 6;

            // Act
            newList.Add(4);
            newList.Add(6);

            // Assert
            Assert.AreEqual(expectedResult, newList[1]);
        }

        [TestMethod]
        public void AddMethod_FirstIndexCheckAfterSecondPush_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 4;

            // Act
            newList.Add(4);
            newList.Add(6);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        public void AddMethod_ListLengthCheckAfterLimitIsHit_isNotEqualToo()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
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
        public void AddMethod_FirstIndexTypeCheckAfterMultiplePushes_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
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
        //   - Check the first index value after the second index value is removed to see if the value is equal to the second index beforehand
        //   - Check list count after removing an item
        //   - Check list count after removing 10 items
        //   - Check the index values after removing 3 items

        [TestMethod]
        public void RemoveMethod_FirstIndexCheckForZeroValueAfterRemove_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 0;

            // Act
            newList.Add(1);
            newList.Remove(1);

            // Assert
            Assert.AreEqual(expectedResult, newList.Count);

        }

        [TestMethod]
        public void RemoveMethod_SecondIndexCheckForValueEqualToThirdBeforeRemove_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 3;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList[1]);
        }

        [TestMethod]
        public void RemoveMethod_FirstIndexCheckAfterSecondIndexRemoved_isEqualToo()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 1;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        public void RemoveMethod_CountCheckAfterRemovingOneIndex()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 1;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }

        [TestMethod]
        public void RemoveMethod_IndexCheckAfterRemovingThreeValues()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 4;

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Remove(3);
            newList.Remove(1);
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        // ToString
        //   - Check to see if the contents of a single index can be converted
        //   - Check to see if the contents of multiple index(s) can be converted
        //   - Check to see if the first index is converted after removing the second index
        //   - Check to make sure the count is equal to the beginning count after converting
        //   - Check if an int is converted to type string successfully

        [TestMethod]
        public void ToStringMethod_CheckIndexForStringConvertion_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            string expectedResult = "1";

            // Act
            newList.Add(1);
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckMultiplyIndexValuesForStringConvertion_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            string expectedResult = "123";

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckFirstIndexAfterRemovingSecondIndexForStringConvertion_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            string expectedResult = "13";

            // Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Remove(2);
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckListCountAfterConvertion_isEqual()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();
            int expectedResult = 1;

            // Act
            newList.Add(1);
            newList[0].ToString();
            int actualResult = newList.Count;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckIndexTypeAfterConvertion_isEqual()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>();

            // Act
            newList.Add(1);
            var actualResult = newList[0].ToString();
            // var actualResult = newList[0];

            // Assert
            Assert.IsInstanceOfType(actualResult, typeof(string));
        }

        //// Zip
        ////   - Check to make sure two list are successfully zipped
        ////   - Check to make sure the data is in the correct order after zip
        ////   - Check to make sure the data is the correct type after zip
        ////   - Check to make sure two different data type do not zip successfully
        ////   - Check to make sure zip returns the appropiate length  (count should be equal to both counts combined)

        //[TestMethod]
        //private static void ZipMethod_CheckNewListForSuccessfulZipIndex0_isTrue()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

        //    // Act
        //    var beforezipList = list1;
        //    list1.Zip(list2);
        //    var expectedResult = expectedList[0];
        //    // Assert
        //    Assert.AreEqual(expectedResult, list1[0]);
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckNewListForSuccessfulZipIndex1_isTrue()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

        //    // Act
        //    var beforezipList = list1;
        //    list1.Zip(list2);
        //    var expectedResult = expectedList[1];
        //    // Assert
        //    Assert.AreEqual(expectedResult, list1[1]);
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckNewListForSuccessfulZipIndex2_isTrue()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

        //    // Act
        //    var beforezipList = list1;
        //    list1.Zip(list2);
        //    var expectedResult = expectedList[2];
        //    // Assert
        //    Assert.AreEqual(expectedResult, list1[2]);
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckNewListForCorrectOrderAfterZip_isTrue()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int> { 2, 1, 4, 3, 6, 5 };

        //    // Act
        //    list2.Zip(list1);
        //    var expectedResult = expectedList;
        //    // Assert
        //    Assert.AreEqual(expectedResult, list2);
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckListForSameTypePostZip_isEqual()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

        //    // Act
        //    list1.Zip(list2);
        //    var expectedResult = expectedList;
        //    // Assert
        //    Assert.IsInstanceOfType(expectedResult, typeof(string));
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckListForIncompatableTypePreZip_isNotEqual()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> expectedList = new CustomList<int>();

        //    // Act
        //    expectedList = list1.Zip(list2);
        //    var expectedResult = expectedList;
        //    // Assert
        //    Assert.IsNull(expectedResult);
        //}

        //[TestMethod]
        //private static void ZipMethod_CheckCountAfterZipForEqualLengthFromBothListCombined_isEqual()
        //{
        //    // Arrange
        //    CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
        //    CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
        //    CustomList<int> combinedList = new CustomList<int>();
        //    CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

        //    // Act
        //    combinedList = list1.Zip(list2);
        //    // Assert
        //    Assert.AreEqual(expectedList.Count, combinedList.Count);
        //}

        //// Overload + Operator
        ////   - 
        ////   - 
        ////   - 
        ////   - 
        ////   - 

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //// Overload - Operator
        ////   - 
        ////   - 
        ////   - 
        ////   - 
        ////   - 

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}

        //[TestMethod]
        //private static void nameHere()
        //{
        //    // Arrange

        //    // Act

        //    // Assert

        //}
    }
}
