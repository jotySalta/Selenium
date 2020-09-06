using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace QQ_LoginTest
{
    class Program
    {
    
        static void Main(string[] args)
          {

            var driver = new ChromeDriver();

            
            driver.Navigate().GoToUrl("https://sima.otnpb.gob.bo");
            driver.Manage().Window.Maximize();

            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var login = driver.SwitchTo().ActiveElement(); // .Frame(driver.FindElementByClassName("login-page"));
           
            login.FindElement(By.Id("email")).SendKeys("tarija@otnpb.com.bo");
            login.FindElement(By.Id("password")).SendKeys("Simaotnpb21!");
            login.FindElement(By.ClassName("btn-inverse")).Click(); //.Submit();//



            Thread.Sleep(10000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            


            var obj = login.FindElement(By.XPath("//*[@title='MET CANCHASMAYO']"));
            obj.Click();
           
            var obj1 = login.FindElement(By.ClassName("flatWeather"));
            
            var es = 0;


            //if (login.FindElement(By.Id("err_m")).Text.Trim() == "请输入正确的帐号！")
            //{
            //    Console.WriteLine("账号错误");
            //}
            //else
            //{
            //    //登陆QQ
            //    login.FindElement(By.Id("login_button")).Click();

            //}

            ////获取到验证区域
            //IWebDriver validate = login.SwitchTo().Frame(login.FindElement(By.TagName("iframe")));

            //Thread.Sleep(2000);
            //var slideBkg = validate.FindElement(By.Id("slideBkg"));//获取滑动验证图片
            //Console.WriteLine(slideBkg.Size.Width);
            //Console.WriteLine(slideBkg.Size.Height);

            ////例如（带阴影）地址：https://hy.captcha.qq.com/hycdn_1_1585770526512857856_0
            //string newUrl = slideBkg.GetAttribute("src");
            ////原图地址：https://hy.captcha.qq.com/hycdn_0_1585770526512857856_0
            ////用正则匹配并替换
            //string oldUrl = new Regex(@"_\d_", RegexOptions.Multiline).Replace(newUrl,"_0_");
            ////根据地址获取到图像
            //Bitmap oldBmp = (Bitmap)LoginHelper.GetImg(oldUrl);
            //Bitmap newBmp = (Bitmap)LoginHelper.GetImg(newUrl);

            //driver.GetScreenshot().SaveAsFile("原图.png");
            //oldBmp.Save("原始验证图.png");
            //newBmp.Save("阴影验证图.png");

            //int left = LoginHelper.GetArgb(oldBmp, newBmp);//得到阴影到图片左边界的像素
            //int leftShift = (int)(left * ((double)slideBkg.Size.Width / (double)newBmp.Width) - 18);//得到真实的偏移值


            ////validate.SwitchTo();

            //var slideBlock = validate.FindElement(By.Id("slideBlock"));//获取到滑块
            //Console.WriteLine($"开始位置：{slideBlock.Location.X}");
            //Actions actions = new Actions(driver);
            ////actions.ClickAndHold(slideBlock).Build().Perform();
            ////actions.DragAndDropToOffset(slideBlock, 50, 0).Perform();
            ////actions.Click(tcaptcha_drag_button).Perform();
            ////actions.ClickAndHold(tcaptcha_drag_button).Release().Perform();
            //actions.DragAndDropToOffset(slideBlock, leftShift, 0).Build().Perform();//单击并在指定的元素上按下鼠标按钮,然后移动到指定位置
            ////Thread.Sleep(2000);
            ////Console.WriteLine($"移动后位置：{slideBlock.Location.X}");
            ////actions.DragAndDropToOffset(slideBlock,leftShift, 0).Perform();//移动滑块到阴影处
            ////Thread.Sleep(2000);
            //driver.GetScreenshot().SaveAsFile("移动后图片.png");





        }






    }
}
