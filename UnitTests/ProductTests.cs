using BusinessLogic;
using Moq;
using Repository;
using UnitTests.TestData;
using Xunit;

namespace UnitTests
{
    public class ProductTests
    {
        [Fact]
        public void TopTenProductList()
        {
	        var demoDataContext = new Mock<IDatabaseContext>();
	        demoDataContext.Setup(x => x.Products).Returns(UnitTestHelpers.GetQueryableMockDbSet(ProductTestData.Get(1)));

			var productList = new ProductList(demoDataContext.Object);

	        var result = productList.GetTopTen();
			Assert.Equal(10,result.Count);
        }
	    [Fact]
	    public void TopTenProductListNoData()
	    {
		    var demoDataContext = new Mock<IDatabaseContext>();
		    demoDataContext.Setup(x => x.Products).Returns(UnitTestHelpers.GetQueryableMockDbSet(ProductTestData.Get(2)));

		    var productList = new ProductList(demoDataContext.Object);

		    var result = productList.GetTopTen();
		    Assert.Empty(result);
	    }
	}
}
