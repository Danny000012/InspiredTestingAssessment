using Assessment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment.Tests;

public class OrderTakealotProducts
{
    IWebDriver driver;
    
    [SetUp]
    public void BeforeEach()
    {
        driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        driver.Url = "https://www.takealot.com";
    }
    
    // Test is dataDriven, can change passed on the data passed

    [Test]
    public void Order_Valentines_Item_On_Take_Alot()
    {
        var productCardsPage = new ProductCardsPage(driver);
        var itemSearched = productCardsPage.Goto().GetProductByName("Elizabeth Arden White Tea EDT 50ml For Her");
        
        productCardsPage.FindProductByName("Elizabeth Arden White Tea EDT 50ml For Her");

        Thread.Sleep(2000);
        productCardsPage.ClickItemByName("PLID56139167");
        Thread.Sleep(2000);
        productCardsPage.cartPage.AddProductToCart();
        Thread.Sleep(2000);
        productCardsPage.cartPage.GoToCart();
        var ItemHeader = productCardsPage.cartPage.Map.OrderItemHeader.Text;

        // Data could passed from a model, compare the input that we fed on the property to the what's on the page.
        Assert.AreEqual("Elizabeth Arden White Tea EDT 50ml For Her", ItemHeader);
    }

    [Test]
    public void Item_Searched_Is_On_Product_Page()
    {
        var productCardsPage = new ProductCardsPage(driver);
        var itemSearched = productCardsPage.Goto().GetProductByName("Elizabeth Arden White Tea EDT 50ml For Her");
        
        productCardsPage.FindProductByName("Elizabeth Arden White Tea EDT 50ml For Her");

        Thread.Sleep(2000);
        productCardsPage.ClickItemByName("PLID56139167");
        Thread.Sleep(2000);
        productCardsPage.cartPage.AddProductToCart();
        Thread.Sleep(2000);
        productCardsPage.cartPage.GoToCart();
        var ItemHeader = productCardsPage.cartPage.Map.OrderItemHeader.Text;

        Assert.AreEqual("Elizabeth Arden White Tea EDT 50ml For Her", ItemHeader);
    }

    [TearDown]
    public void AfterEach()
    {
        driver.Quit();
    }
}