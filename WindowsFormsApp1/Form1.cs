using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver;

        private void Form1_Load(object sender, EventArgs e)
        {

            driver = new ChromeDriver();
            driver.Url = "https://google.com";
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Elif Eda Güneş");
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]")).Click();

        }
    }
}
