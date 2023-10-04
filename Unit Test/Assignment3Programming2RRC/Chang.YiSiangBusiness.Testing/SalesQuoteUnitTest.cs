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
using System.ComponentModel;
using Chang.YiSiang.Business;

/*
 * A program to test.
 *
 * @author Yi-Siang Chang
 * @version 1.0.0
 */

namespace Chang.YiSiangBusiness.Testing
{
    [TestClass]
    public class SalesQuoteUnitTest
    {
        //1
        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor_InvalidAccessories_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 5000;
            decimal tradeInAmount = 6000;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //2
        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor_InvalidExteriorFinish_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 5000;
            decimal tradeInAmount = 6000;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //3
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalePriceLessThanZero_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = -12000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.15m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //4
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalePriceZero_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 0;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.15m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //5
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_TradeInAmountLessThanZero_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 12000;
            decimal tradeInAmount = -2000;
            decimal salesTaxRate = 0.15m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //6
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_SalesTaxRateLessThanZero_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 12000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = -0.15m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        //7
        [TestMethod]
        public void Constructor_VehicleSalePrice_Initial()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            PrivateObject target;
            target = new PrivateObject(new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen));

            //Assert
            decimal expected = 5000m;
            decimal actual = (decimal)target.GetProperty("VehicleSalePrice");

            Assert.AreEqual(expected, actual);
        }

        //8
        [TestMethod]
        public void Constructor_TradeInAmount_Initial()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            PrivateObject target;
            target = new PrivateObject(new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen));

            //Assert
            decimal expected = 6000m;
            decimal actual = (decimal)target.GetProperty("TradeInAmount");

            Assert.AreEqual(expected, actual);
        }

        //9
        [TestMethod]
        public void Constructor_SalesTaxRate_Initial()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            PrivateObject target;
            target = new PrivateObject(new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen));

            //Assert
            decimal expected = 0.12m;
            decimal actual = (decimal)target.GetField("salesTaxRate");

            Assert.AreEqual(expected, actual);
        }

        //10
        [TestMethod]
        public void Constructor_AccessoriesChosen_Initial()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            PrivateObject target;
            target = new PrivateObject(new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen));

            //Assert
            Accessories expected = Accessories.All;
            Accessories actual = (Accessories)target.GetProperty("AccessoriesChosen"); // 要對應 SalesQuote.cs 的 第139行 的 AccessoriesChosen

            Assert.AreEqual(expected, actual);
        }

        //11
        [TestMethod]
        public void Constructor_ExteriorFinish_Initial()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            PrivateObject target;
            target = new PrivateObject(new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen));

            //Assert
            ExteriorFinish expected = ExteriorFinish.Standard;
            ExteriorFinish actual = (ExteriorFinish)target.GetProperty("GetExteriorFinishChosen"); // 要對應 SalesQuote.cs 的 GetExteriorFinishChosen

            Assert.AreEqual(expected, actual);
        }

        //12
        [TestMethod]
        public void VehicleSalePriceGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expected = 5000m;
            decimal actual = salesQuote.VehicleSalePrice;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //13
        [TestMethod]
        public void TradeInAmountGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expected = 6000m;
            decimal actual = salesQuote.TradeInAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //14
        [TestMethod]
        public void SalesTaxRateGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expected = 600.00m;
            decimal actual = salesQuote.SalesTax;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //15
        [TestMethod]
        public void AccessoryGetProperty_StereoSystem_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 505.05m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //16
        [TestMethod]
        public void AccessoryGetProperty_LeatherInterior_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1010.10m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //17
        [TestMethod]
        public void AccessoryGetProperty_StereoAndLeather_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoAndLeather;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1010.1m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual); 
        }

        //18
        [TestMethod]
        public void AccessoryGetProperty_ComputerNavigation_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1515.15m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //19
        [TestMethod]
        public void AccessoryGetProperty_StereoAndNavigation_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1515.15m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //20
        [TestMethod]
        public void AccessoryGetProperty_LeatherAndNavigation_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.LeatherAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 2525.25m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //21
        [TestMethod]
        public void AccessoryGetProperty_All_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 2525.25m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //22
        [TestMethod]
        public void AccessoryGetProperty_None_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 12000m;
            decimal tradeInAmount = 2000m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 2525.25m;
            decimal actual = sales.AccessoriesCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //23
        [TestMethod]
        public void ExteriorFinishGetProperty_Standard_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 202.02m;
            decimal actual = sales.ExteriorFinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //24
        [TestMethod]
        public void ExteriorFinishGetProperty_Pearlized_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 404.04m;
            decimal actual = sales.ExteriorFinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //25
        [TestMethod]
        public void ExteriorFinishGetProperty_Custom_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 606.06m;
            decimal actual = sales.ExteriorFinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //26
        [TestMethod]
        public void ExteriorFinishGetProperty_None_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 606.06m;
            decimal actual = sales.ExteriorFinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //27
        [TestMethod]
        public void VehicleSalePriceSetProperty_MoreThanZero_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);
            salesQuote.VehicleSalePrice = 10000m;
            decimal expected = 10000m;
            decimal actual = (decimal)target.GetField("vehicleSalePrice");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //28
        [TestMethod]
        public void VehicleSalePriceSetProperty_Zero_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.VehicleSalePrice = 0m;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 5000m;
                decimal actual = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expected, actual);

            }
        }

        //29
        [TestMethod]
        public void VehicleSalePriceSetProperty_Negative_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.VehicleSalePrice = -10000m;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 5000m;
                decimal actual = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expected, actual);

            }
        }

        //30
        [TestMethod]
        public void TradeInAmountSetProperty_Positive_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 5000m;
            decimal tradeInAmount = 6000m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);
            salesQuote.TradeInAmount = 10000m;
            decimal expected = 10000m;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //31
        [TestMethod]
        public void TradeInAmountSetProperty_Zero_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            sales.TradeInAmount = 0;
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //32
        [TestMethod]
        public void TradeInAmountSetProperty_Negative_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.TradeInAmount = -10000m;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 500m;
                decimal actual = (decimal)target.GetField("tradeInAmount");
                Assert.AreEqual(expected, actual);
            }
        }
        
        //33
        [TestMethod]
        public void FinishCostGetProperty_None_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 0;
            decimal actual = sales.ExteriorFinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //34
        [TestMethod]
        public void TotalOptionsGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 6000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 707.07m;
            decimal actual = sales.TotalOptions;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //35
        [TestMethod]
        public void SubTotalGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 6000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 6707.07m;
            decimal actual = sales.SubTotal;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //36
        [TestMethod]
        public void SalesTaxRateSGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 6000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 804.85m;
            decimal actual = sales.SalesTax;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //37
        [TestMethod]
        public void TotalGetProperty_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 6000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 7511.92m;
            decimal actual = sales.Total;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //38
        [TestMethod]
        public void AmountDue_Return()
        {
            //Arrange
            decimal vehicleSalePrice = 6000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 8143.23m;
            decimal actual = sales.AmountDue;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
