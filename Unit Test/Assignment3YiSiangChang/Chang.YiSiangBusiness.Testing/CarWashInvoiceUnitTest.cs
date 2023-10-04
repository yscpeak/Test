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
    public class CarWashInvoiceUnitTest
    {
        //1
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ProvincialSalesTaxRateLessThanZero_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = -0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = -0.1m;
            decimal actual = carWashInvoice.ProvincialSalesTaxRate;

            Assert.AreEqual(expected, actual);
        }

        //2
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ProvincialSalesTaxRateGreaterThanOne_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 1.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 1.1m;
            decimal actual = carWashInvoice.ProvincialSalesTaxRate;

            Assert.AreEqual(expected, actual);
        }



        //3
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_GoodsAndServiceTaxRateLessThanZero_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = -0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = -0.1m;
            decimal actual = carWashInvoice.GoodsAndServicesTaxRate;

            Assert.AreEqual(expected, actual);

        }

        //4
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_GoodsAndServiceTaxRateGreaterThanOne_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 1.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 1.1m;
            decimal actual = carWashInvoice.GoodsAndServicesTaxRate;

            Assert.AreEqual(expected, actual);

        }

        //5
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PackageCostLessThanZero_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = -0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = -0.1m;
            decimal actual = carWashInvoice.PackageCost;

            Assert.AreEqual(expected, actual);
        }

        //6
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_FragranceCostLessThanZero_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = -0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = -0.1m;
            decimal actual = carWashInvoice.FragranceCost;

            Assert.AreEqual(expected, actual);

        }

        //7
        [TestMethod]
        public static void Constructor_ProvincialSalesTaxRate_Initial()
        {
            // Setup test data
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0.1m;
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        //8
        [TestMethod]
        public static void Constructor_GoodsAndServicesTaxRate_Initial()
        {
            // Setup test data
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0.1m;
            decimal actual = (decimal)target.GetField("goodsAndServicesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        //9
        [TestMethod]
        public static void Constructor_PackageCost_Initial()
        {
            // Setup test data
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0.1m;
            decimal actual = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expected, actual);
        }

        //10
        [TestMethod]
        public static void Constructor_FragranceCost_Initial()
        {
            // Setup test data
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0.1m;
            decimal actual = (decimal)target.GetProperty("fragranceCost");
            Assert.AreEqual(expected, actual);
        }

        //11
        [TestMethod]
        public static void Constructor_PackageCost_Zero_Initial()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0m;
            decimal actual = (decimal)target.GetProperty("packageCost");
            Assert.AreEqual(expected, actual);
        }

        //12
        [TestMethod]
        public static void Constructor_FragranceCost_Zero_Initial()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            // Act
            PrivateObject target;
            target = new PrivateObject(new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost));

            //Assert
            decimal expected = 0m;
            decimal actual = (decimal)target.GetProperty("fragranceCost");
            Assert.AreEqual(expected, actual);
        }

        //13
        [TestMethod]
        public static void ProvincialSalesTaxChargedGetProperty_Return()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 0m;
            decimal actual = carWashInvoice.ProvincialSalesTaxCharged;

            Assert.AreEqual(expected, actual);
        }

        //14
        [TestMethod]
        public static void GoodsAndServicesTaxChargedGetProperty_Return()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 0m;
            decimal actual = carWashInvoice.GoodsAndServicesTaxCharged;

            Assert.AreEqual(expected, actual);
        }

        //15
        [TestMethod]
        public static void PackageCostGetProperty_Return()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 0.1m;
            decimal actual = carWashInvoice.PackageCost;

            Assert.AreEqual(expected, actual);
        }

        //16
        [TestMethod]
        public static void FragranceCostGetProperty_Return()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 0.1m;
            decimal actual = carWashInvoice.FragranceCost;

            Assert.AreEqual(expected, actual);
        }

        //17
        [TestMethod]
        public void SubTotalGetProperty_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //Assert
            decimal expected = 0.1m;
            decimal actual = carWashInvoice.FragranceCost;

            Assert.AreEqual(expected, actual);
        }

        //18
        [TestMethod]
        public void PackageCostSetProperty_MoreThanZero_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWashInvoice.PackageCost = 10m;
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal expected = 10m;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //19
        [TestMethod]
        public void PackageCostSetProperty_Zero_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWashInvoice.PackageCost = 0;
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //20
        [TestMethod]
        public void PackageCostPropertySet_LessThanZero_NoUpdate()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);

            try
            {
                carWash.PackageCost = -0.1m;
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWash);
                decimal expected = 0.1m;
                decimal actual = (decimal)target.GetField("packageCost");

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        //21
        [TestMethod]
        public void FragranceCostSetProperty_MoreThanZero_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.FragranceCost = 10m;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 10m;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //22
        [TestMethod]
        public void FragranceCostSetProperty_Zero_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.FragranceCost = 0;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //23
        [TestMethod]
        public void FragranceCostSetProperty_LessThanZero_NoUpdate()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = 0.1m;

            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);

            try
            {
                carWash.FragranceCost = -0.1m;
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWash);
                decimal expected = 0.1m;
                decimal actual = (decimal)target.GetField("fragranceCost");

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        //24
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PackageCostSetProperty_PackageCost_LessThanZero_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = -0.1m;
            decimal fragranceCost = 0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal actual = carWashInvoice.PackageCost;
        }

        //25
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FragranceCostPropertySet_NegativePackageCost_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.1m;
            decimal goodsAndServiceTaxRate = 0.1m;
            decimal packageCost = 0.1m;
            decimal fragranceCost = -0.1m;

            //Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal actual = carWashInvoice.FragranceCost;
        }
    }
}
