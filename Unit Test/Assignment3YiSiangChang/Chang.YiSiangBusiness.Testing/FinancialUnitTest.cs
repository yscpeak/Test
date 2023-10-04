/*
 * Name: Yi Siang Chang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-02-10
 * Updated: 2023-03-03
 */

using Chang.YiSiang.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

/*
 * A program to test.
 *
 * @author Yi-Siang Chang
 * @version 1.0.0
 */

namespace Chang.YiSiangBusiness.Testing
{
    [TestClass]
    public class FinancialUnitTest
    {
        //1
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_RateLessThanZero_Exception()
        {
            //Arrange
            decimal rate = -0.01m;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //2
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_RateMoreThanOne_Exception()
        {
            // Arrange
            decimal rate = 1.01m;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //3
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_NumberOfPaymentPeriodsEqualToZero_Exception()
        {
            // Arrange
            decimal rate = 0.01m;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //4
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_NumberOfPaymentPeriodsLessThanZero_Exception()
        {
            // Arrange
            decimal rate = 0.01m;
            int numberOfPaymentPeriods = -1;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //5
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PresentValueEqualToZero_Exception()
        {
            // Arrange
            decimal rate = 0.01m;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 0m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //6
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PresentValueLessThanZero_Exception()
        {
            // Arrange
            decimal rate = 0.01m;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = -0.01m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //7
        [TestMethod]
        public static void Constructor_RateValidArguments_Initial()
        {
            // Setup test data
            decimal rate = 0.1m / 12;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //8
        [TestMethod]
        public static void Constructor_NumberOfPaymentPeriodsValidArguments_Initial()
        {
            // Setup test data
            decimal rate = 0.1m / 12;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //9
        [TestMethod]
        public static void Constructor_PresentValueValidArguments_Initial()
        {
            // Setup test data
            decimal rate = 0.1m / 12;
            int numberOfPaymentPeriods = 48;
            decimal presentValue = 20748.4m;

            // Act
            decimal target = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        //10
        [TestMethod]
        public void RateEqualToZero_Return()
        {
            //Arrange
            decimal rate = 0;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal expected = 166.67m;
            decimal actual = payment;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //11
        [TestMethod]
        public static void NumberOfPaymentPeriodsMoreThanZero_Return()
        {
            //Arrange
            decimal rate = 0;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal expected = 166.67m;
            decimal actual = payment;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //12
        [TestMethod]
        public static void PresentValueMoreThanZero_Return()
        {
            //Arrange
            decimal rate = 0;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal expected = 166.67m;
            decimal actual = payment;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
