using global::LaptopDiscount;


namespace DiscountApp.nUnitTests
{
    [TestFixture]
    public class DiscountTests
    {
        [Test]
        public void CalculateDiscountedPrice_ForPartTimeEmployee_ShouldReturnFullPrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 1000m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(1000m, result);
        }

        [Test]
        public void CalculateDiscountedPrice_ForPartialLoadEmployee_ShouldReturnDiscountedPrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 1000m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(950m, result);
        }

        [Test]
        public void CalculateDiscountedPrice_ForFullTimeEmployee_ShouldReturnDiscountedPrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 1000m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(900m, result);
        }

        [Test]
        public void CalculateDiscountedPrice_ForCompanyPurchasing_ShouldReturnDiscountedPrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 1000m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(800m, result);
        }

        [Test]
        public void CalculateDiscountedPrice_ForZeroPrice_ShouldReturnZero()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 0m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(0m, result);
        }

        [Test]
        public void CalculateDiscountedPrice_ForNegativePrice_ShouldReturnNegativeDiscountedPrice()
        {
            // Arrang
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -1000m
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(-900m, result);
        }
    }
}