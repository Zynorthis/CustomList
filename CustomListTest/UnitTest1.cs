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
            CustomList<int> newList = new CustomList<int>() { 1 };
            int expectedResult = 0;

            // Act
            newList.Remove(1);

            // Assert
            Assert.AreEqual(expectedResult, newList.Count);

        }

        [TestMethod]
        public void RemoveMethod_SecondIndexCheckForValueEqualToThirdBeforeRemove_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2, 3 };
            int expectedResult = 3;

            // Act
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList[1]);
        }

        [TestMethod]
        public void RemoveMethod_FirstIndexCheckAfterSecondIndexRemoved_isEqualToo()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2, 3 };
            int expectedResult = 1;

            // Act
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList[0]);
        }

        [TestMethod]
        public void RemoveMethod_CountCheckAfterRemovingOneIndex()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2 };
            int expectedResult = 1;

            // Act
            newList.Remove(2);

            // Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }

        [TestMethod]
        public void RemoveMethod_IndexCheckAfterRemovingThreeValues()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expectedResult = 4;

            // Act
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
            CustomList<int> newList = new CustomList<int>() { 1 };
            string expectedResult = "1";

            // Act
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckMultiplyIndexValuesForStringConvertion_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2, 3 };
            string expectedResult = "123";

            // Act
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckFirstIndexAfterRemovingSecondIndexForStringConvertion_isTrue()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1, 2, 3 };
            string expectedResult = "13";

            // Act
            newList.Remove(2);
            string actualResult = newList.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckListCountAfterConvertion_isEqual()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1 };
            int expectedResult = 1;

            // Act
            newList[0].ToString();
            int actualResult = newList.Count;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStringMethod_CheckIndexTypeAfterConvertion_isEqual()
        {
            // Arrange
            CustomList<int> newList = new CustomList<int>() { 1 };

            // Act
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

        [TestMethod]
        public void ZipMethod_CheckNewListForSuccessfulZipIndex0_isTrue()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            // Act
            var resultList = list1.Zip(list2);
            var expectedResult = expectedList[0];
            // Assert
            Assert.AreEqual(expectedResult, resultList[0]);
        }

        [TestMethod]
        public void ZipMethod_CheckNewListForSuccessfulZipIndex1_isTrue()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

            // Act
            var resultList = list1.Zip(list2);
            var expectedResult = expectedList[1];
            // Assert
            Assert.AreEqual(expectedResult, resultList[1]);
        }

        [TestMethod]
        public void ZipMethod_CheckNewListForSuccessfulZipIndex2_isTrue()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

            // Act
            var resultList = list1.Zip(list2);
            var expectedResult = expectedList[2];
            // Assert
            Assert.AreEqual(expectedResult, resultList[2]);
        }

        [TestMethod]
        public void ZipMethod_CheckNewListForCorrectOrderAfterZip_isTrue()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int> { 2, 1, 4, 3, 6, 5 };

            // Act
            var resultList = list2.Zip(list1);
            var actualResults = resultList.ToString();
            var expectedResult = expectedList.ToString();
            // Assert
            Assert.AreEqual(expectedResult, actualResults);
        }

        [TestMethod]
        public void ZipMethod_CheckListForSameTypePostZip_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

            // Act
            var resultList = list1.Zip(list2);
            var expectedResult = expectedList;
            // Assert
            Assert.IsInstanceOfType(expectedResult, typeof(CustomList<int>));
        }

        [TestMethod]
        public void ZipMethod_CheckListAfterZipIfListAreTwoDifferentSizes_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5, 7, 8, 9, 10};
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var actualResult = list1.Zip(list2);
            var expectedResult = expectedList.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [TestMethod]
        public void ZipMethod_CheckCountAfterZipForEqualLengthFromBothListCombined_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> combinedList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            // Act
            combinedList = list1.Zip(list2);
            // Assert
            Assert.AreEqual(expectedList.Count, combinedList.Count);
        }

        // Overload + Operator
        //   - list1 + list2
        //   - list1 + list2 + list3
        //   - make sure count is correct
        //   - 
        //   - 

        [TestMethod]
        public void AddOperatorMethod_CheckToSeeIfIndexZeroIsEqualToTheExpectValue_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 1;

            // Act
            ResultList = (list1 + list2);

            // Assert
            Assert.AreEqual(expectedResult, ResultList[0]);
        }

        [TestMethod]
        public void AddOperatorMethod_CheckToSeeIfIndexOneIsEqualToTheExpectValue_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 2;

            // Act
            ResultList = (list1 + list2);

            // Assert
            Assert.AreEqual(expectedResult, ResultList[1]);
        }

        [TestMethod]
        public void AddOperatorMethod_CheckToSeeIfIndexThreeIsEqualToTheExpectValue_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 4;

            // Act
            ResultList = (list1 + list2);

            // Assert
            Assert.AreEqual(expectedResult, ResultList[3]);
        }
        [TestMethod]
        public void AddOperatorMethod_CheckToSeeIfIndexFiveIsEqualToTheExpectValue_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 6;

            // Act
            ResultList = (list1 + list2);

            // Assert
            Assert.AreEqual(expectedResult, ResultList[5]);
        }

        [TestMethod]
        public void AddOperatorMethod_CheckResultListCount_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            // Act
            ResultList = (list1 + list2);

            // Assert
            Assert.AreEqual(expectedResult.Count, ResultList.Count);
        }

        [TestMethod]
        public void AddOperatorMethod_CheckResultAfterAddingThreeListTogether()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> list3 = new CustomList<int>() { 7, 8, 9 };
            CustomList<int> ResultList = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            ResultList = (list1 + list2 + list3);

            // Assert

        }

        [TestMethod]
        public void AddOperatorMethod_CheckListTypeAfterAddingTwoListTogether_isTypeOf()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ResultList = new CustomList<int>();

            // Act
            ResultList = list1 + list2;

            // Assert
            Assert.IsInstanceOfType(ResultList, typeof(CustomList<int>));
        }

        // Overload - Operator
        //   - I Did
        //   - Stuff
        //   - And it
        //   - worked.
        //   - yay

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultIndexOneAfterSubtractingIndexOne_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 2;

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.AreEqual(expectedResult, ResultList[0]);
        }

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultIndexTwoAfterSubtractingIndexOne_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 3;

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.AreEqual(expectedResult, ResultList[1]);
        }

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultIndexOneAfterSubtractingIndexTwo_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 5 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 1;

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.AreEqual(expectedResult, ResultList[0]);
        }

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultIndexOneAfterSubtractingIndexOneAndIndexTwo_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 2, 5 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 3;

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.AreEqual(expectedResult, ResultList[0]);
        }

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultCountAfterSubtractingIndexOne_isEqual()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> ResultList = new CustomList<int>();
            int expectedResult = 2;

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.AreEqual(expectedResult, ResultList.Count);
        }

        [TestMethod]
        public void SubtractOperatorMethod_CheckResultTypeAfterSubtraction_isTypeOf()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> ResultList = new CustomList<int>();

            // Act
            ResultList = list1 - list2;

            // Assert
            Assert.IsInstanceOfType(ResultList, typeof(CustomList<int>));
            }
    }
}
