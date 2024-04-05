using UnitTestUitleg;

namespace UnitTestTests
{
    public class OrderTest
    {
        [Fact]
        public void TotalPrice_OnlyOneItem_ReturnsPriceItem()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 10 });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(10, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_NoItems_ReturnsZero()
        {
            // Arrange
            var sut = new Order();

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(0, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_TwoItems_ReturnsSumOfPrices()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 10 });
            sut.OrderItems.Add(new OrderItem { Price = 20 });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(30, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_ItemsWorth100_Returns5PercentDiscount()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 50 });
            sut.OrderItems.Add(new OrderItem { Price = 50 });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(95, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_ItemsWorth99_ReturnsNoDiscount()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 49m });
            sut.OrderItems.Add(new OrderItem { Price = 50m });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(99, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_ItemsWorth101_Returns5PercentDiscount()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 50m });
            sut.OrderItems.Add(new OrderItem { Price = 51m });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(95.95m, calculatedTotalPrice);
        }

        [Fact]
        public void TotalPrice_ItemsWorth200_Returns5PercentDiscount()
        {
            // Arrange
            var sut = new Order();
            sut.OrderItems.Add(new OrderItem { Price = 100m });
            sut.OrderItems.Add(new OrderItem { Price = 100m });

            // Act
            var calculatedTotalPrice = sut.TotalPrice;

            // Assert
            Assert.Equal(190, calculatedTotalPrice);
        }
    }
}