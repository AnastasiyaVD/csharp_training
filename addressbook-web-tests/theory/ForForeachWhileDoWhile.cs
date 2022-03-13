using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace addressbook_web_tests
{
    [TestClass]
    public class ForForeachWhileDoWhile
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] s = new string[] { "I", "want", "to", "sleep", }; //объявляем массив строк

            //1 способ:
            for (int i = 0; i < s.Length; i++) //Длина массива
            {
            System.Console.Out.Write(s[i] + "\n"); //обращаемся к элементу массива по индексу
            }
            
            
        }


        [TestMethod]
        public void TestMethod2()
        {
            string[] s = new string[] { "I", "want", "to", "sleep", }; //объявляем массив строк

            //2 способ лучше:
            foreach (string element in s)
            {
                System.Console.Out.Write(element + "\n"); //обращаемся к элементу массива напрямую
            }
        }

        [TestMethod]
        public void TestMethod3()
        {

            // пример while 1 способ:
            IWebDriver driver = null;
            int attempt = 0; //задаем количество попыток, чтобы не уйти в бесконечное выполнение теста

            while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60) //если элемента нет, тогда значение равно 0 и количество попыток не превысело 60 значит выполняем условие далее
            {
                System.Threading.Thread.Sleep(1000); //подождать 1000 ms и снова проверка
                attempt++; //увеличиваем количество попыток на +1
            }
            // ....

            // пример while 2 способ:
            do  // сначала заходим в тело цикла, а затем проверка
            {
                System.Threading.Thread.Sleep(1000); //подождать 1000 ms и снова проверка
                attempt++; //увеличиваем количество попыток на +1
            }
            while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60); //если элемента нет, тогда значение равно 0 и количество попыток не превысело 60 значит выполняем условие далее
            //...
        }
    }
}
