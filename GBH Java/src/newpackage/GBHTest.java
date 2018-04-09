package newpackage;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;


public class GBHTest {

	private static ChromeDriver _driver;

	@BeforeClass
	public static void Setup()
	{
	    _driver = new ChromeDriver();
	    OpenGBH();
	}
	
    private static void OpenGBH()
    {
        _driver.get("http://gbh.com.do/");
    }
	
	@Test
    public void Inicio()
    {
        WebElement inicio = _driver.findElement(By.id("menu-item-21"));
        inicio.click();

        WebElement servicios = _driver.findElement(By.id("servicios"));
        Assert.assertEquals(true, servicios.isDisplayed());
    }
	
	@Test
    public void servicios()
    {
        WebElement servicios = _driver.findElement(By.id("menu-item-209"));
        WebElement UX = _driver.findElement(By.id("menu-item-2642"));
        servicios.click();
        UX.click();

        WebElement contactservice = _driver.findElement(By.id("contact-service"));
        Assert.assertEquals(true, contactservice.isDisplayed());
    }
	
	@Test
    public void Portafolio()
    {
        WebElement portafolio = _driver.findElement(By.id("menu-item-62"));
        portafolio.click();

        WebElement filtro = _driver.findElement(By.className("boxwhite-panel-title"));
        Assert.assertEquals(true, filtro.isDisplayed());
    }
	
	@Test
    public void Conocenos()
    {
        WebElement conocenos = _driver.findElement(By.id("menu-item-65"));
        conocenos.click();

        WebElement jrod = _driver.findElement(By.className("portfolio_thumbnail"));
        Assert.assertEquals(true, jrod.isDisplayed());
    }
	
	@Test
    public void Empleos()
    {
        WebElement empleos = _driver.findElement(By.id("menu-item-126"));
        empleos.click();

        WebElement testimonio = _driver.findElement(By.className("prelative"));
        Assert.assertEquals(true, testimonio.isDisplayed());
    }
	
	@Test
    public void Blog()
    {
        WebElement blog = _driver.findElement(By.id("menu-item-20"));
        blog.click();

        WebElement subscribir = _driver.findElement(By.id("mc-embedded-subscribe"));
        Assert.assertEquals(true, subscribir.isDisplayed());
    }
	
	 @AfterClass
	 public static void closeBrowser(){
		 _driver.quit();
	 }


}