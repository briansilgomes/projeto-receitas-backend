using Xunit;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace Receitas.testesUi
{
    public class TestLogin
    {
        [Fact]
        public void Login()
        {

            var site = new EdgeDriver();
            site.Url = "http://localhost:4200/login";


            var username = site.FindElement(By.Id("txtname"));
            username.SendKeys("briangomes@sapo.pt");
            var password = site.FindElement(By.Id("txtpassword"));
            password.SendKeys("123");
            var login = site.FindElement(By.Id("btsubmit"));
            login.Click();

            var urlrecipe = site.FindElement(By.TagName("h1"));
            Assert.Equal(urlrecipe.Text, "RECEITAS");


        }
    }
}