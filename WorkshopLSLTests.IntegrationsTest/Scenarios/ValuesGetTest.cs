using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WorkshopLSLTests.IntegrationsTest.Fixtures;
using Xunit;

namespace WorkshopLSLTests.IntegrationsTest.Scenarios
{
    public class ValuesGetTest
    {
        private readonly TestContext _testContext;
        public ValuesGetTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task ReturnsSuccessResponse_GivenListAllValues() 
        {
            //Arrange
            var response = await _testContext.Client.GetAsync("api/values");
            
            //Act
            response.EnsureSuccessStatusCode();
            
            //Assert
            var expected = HttpStatusCode.OK;
            var actual = response.StatusCode;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-200)]
        [InlineData(0)]
        public async Task ReturnsInternalServerErrorReponse_GivenValuesNegativeOrZero(int value)
        {
            //Arrange
            var response = await _testContext.Client.GetAsync(string.Format("api/values/{0}", value));

            //Act
            Assert.Throws<HttpRequestException>(
                //Assert
                () => response.EnsureSuccessStatusCode()
            );
        }


        [Theory]
        [InlineData(1)]
        [InlineData(200)]
        [InlineData(2)]
        public async Task ReturnsSucessReponse_GivenValuesPositive(int value)
        {
            //Arrange
            var response = await _testContext.Client.GetAsync(string.Format("api/values/{0}", value));

            //Act
            response.EnsureSuccessStatusCode();

            //Assert
            var expected = HttpStatusCode.OK;
            var actual = response.StatusCode;

            Assert.Equal(expected, actual);
        }
    }
}
