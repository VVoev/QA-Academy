﻿namespace QAAcademyDemo.Telerik.Core.Pages_01.ShoppingCartPage
{
    using OpenQA.Selenium;

    public class ShoppingCartPage : BasePage<ShoppingCartPageMap, ShoppingCartPageAsserter>
    {
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
        }

        public ShoppingCartPage ChangeQuantity(int quantity)
        {
            return this;
            ////this.Map.Quantity
        }

        public ShoppingCartPage SetCoupon(string coupon)
        {
            return this;
            ////this.Map.Quantity
        }

        public override void Navigate()
        {
            this.Driver.Navigate().GoToUrl("https://www.telerik.com/account/shopping-cart.aspx");
        }
    }
}