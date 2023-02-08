using Assessment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment.Tests;

public class OrderTakealotProductTest
{
    IWebDriver driver;
    
    [SetUp]
    public void BeforeEach()
    {
        driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        driver.Url = "https://www.takealot.com";
    }

    [Test]
    public void TakelotOrder()
    {

    }

    [Test]
    public void Item_Searched_Is_On_Product_Page()
    {
        var productCardsPage = new ProductCardsPage(driver);
        var ItemSearched = productCardsPage.Goto().GetProductByName("Elizabeth Arden White Tea EDT 50ml For Her");
        
        productCardsPage.ClickProductByName("Elizabeth Arden White Tea EDT 50ml For Her");
        
        Assert.That(ItemSearched.Displayed);
    }

    [TearDown]
    public void AfterEach()
    {
        driver.Quit();
    }
}