using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBHTest
{
    [TestFixture]
    public class GBHTest
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;

        [Test]
        public void Inicio()
        {
            IWebElement inicio = _driver.FindElement(By.Id("menu-item-21"));
            inicio.Click();

            IWebElement servicios = _driver.FindElement(By.Id("servicios"));
            Assert.AreEqual(true, servicios.Displayed, "Pantalla de Inicio no se desplego");
        }

        [Test]
        public void Servicios01()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement UX = _driver.FindElement(By.Id("menu-item-2642"));

            servicios.Click();
            UX.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios02()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement DesarrolloSoft = _driver.FindElement(By.Id("menu-item-2976"));

            servicios.Click();
            DesarrolloSoft.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios03()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement DisenoPag = _driver.FindElement(By.Id("menu-item-226"));

            servicios.Click();
            DisenoPag.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios04()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement ManejoRS = _driver.FindElement(By.Id("menu-item-2895"));

            servicios.Click();
            ManejoRS.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios05()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement ConsultoriaWeb = _driver.FindElement(By.Id("menu-item-1998"));

            servicios.Click();
            ConsultoriaWeb.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios06()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement SEO = _driver.FindElement(By.Id("menu-item-227"));

            servicios.Click();
            SEO.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios07()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement MPC = _driver.FindElement(By.Id("menu-item-361"));

            servicios.Click();
            MPC.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios08()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement EvaluacionIT = _driver.FindElement(By.Id("menu-item-392"));

            servicios.Click();
            EvaluacionIT.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios09()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement ConfigRespaldo = _driver.FindElement(By.Id("menu-item-360"));

            servicios.Click();
            ConfigRespaldo.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios10()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement InsCableado = _driver.FindElement(By.Id("menu-item-357"));

            servicios.Click();
            InsCableado.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios11()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement InsWifi = _driver.FindElement(By.Id("menu-item-358"));

            servicios.Click();
            InsWifi.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Servicios12()
        {
            IWebElement servicios = _driver.FindElement(By.Id("menu-item-209"));
            IWebElement CertCableado = _driver.FindElement(By.Id("menu-item-356"));

            servicios.Click();
            CertCableado.Click();
            IWebElement contactservice = _driver.FindElement(By.Id("contact-service"));
            Assert.AreEqual(true, contactservice.Displayed, "Pantalla no se desplego");
        }

        [Test]
        public void Portafolio()
        {
            IWebElement portafolio = _driver.FindElement(By.Id("menu-item-62"));
            portafolio.Click();

            IWebElement desarrollo = _driver.FindElement(By.ClassName("path-desarrollo"));
            Assert.AreEqual(true, desarrollo.Displayed, "Pantalla de Portafolio no se desplego");
        }

        [Test]
        public void Conocenos()
        {
            IWebElement conocenos = _driver.FindElement(By.Id("menu-item-65"));
            conocenos.Click();

            IWebElement jrod = _driver.FindElement(By.ClassName("portfolio_thumbnail"));
            Assert.AreEqual(true, jrod.Displayed, "Pantalla de Conocenos no se desplego");
        }

        [Test]
        public void Empleos()
        {
            IWebElement empleos = _driver.FindElement(By.Id("menu-item-126"));
            empleos.Click();

            IWebElement testimonio = _driver.FindElement(By.ClassName("prelative"));
            Assert.AreEqual(true, testimonio.Displayed, "Pantalla de empleos no se desplego");
        }

        [Test]
        public void Blog()
        {
            IWebElement blog = _driver.FindElement(By.Id("menu-item-20"));
            blog.Click();

            IWebElement subscribir = _driver.FindElement(By.Id("mc-embedded-subscribe"));
            Assert.AreEqual(true, subscribir.Displayed, "Pantalla de blog no se desplego");
        }

        private void OpenGBH()
        {
            _driver.Navigate().GoToUrl("http://gbh.com.do/");
        }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
            OpenGBH();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
