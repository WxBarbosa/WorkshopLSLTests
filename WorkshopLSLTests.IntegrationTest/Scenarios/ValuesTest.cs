using System.Net;
using System.Threading.Tasks;
using WorkshopLSLTests.IntegrationTest.Fixtures;
using Xunit;

namespace WorkshopLSLTests.IntegrationTest.Scenarios
{
    public class ValuesTest
    {
        private readonly TestContext _testContext;
        public ValuesTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task RetunsOkResponseGivenValuesGet()
        {
            //Arrange
            var response = await _testContext.Client.GetAsync("api/values");
            
            //Act
            response.EnsureSuccessStatusCode();
            
            //Assert
            var expected = response.StatusCode;
            var actual = HttpStatusCode.OK;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task ReturnsOkReponseGivenValuesGetById()
        {
            //Arrange
            var response = await _testContext.Client.GetAsync("api/values/1");

            //Act
            response.EnsureSuccessStatusCode();

            //Assert
            var expected = response.StatusCode;
            var actual = HttpStatusCode.OK;

            Assert.Equal(expected, actual);
        }
    }
}
