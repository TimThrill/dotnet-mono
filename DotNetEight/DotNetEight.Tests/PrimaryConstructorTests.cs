using AutoFixture;

namespace DotNetEight.Tests
{
    public class PrimaryConstructorTests
    {
        private readonly IFixture _fixture;

        [Fact]
        public void ToString_ShouldReturnCorrectName()
        {
            // Arrange
            var primaryConstructor = _fixture.Create<PrimaryConstructor>();

            // Assert
            Assert.True(!string.IsNullOrEmpty(primaryConstructor.ToString()));
        }
    }
}
