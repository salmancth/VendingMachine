using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product
    {
        protected int Price;
        protected string Name;

        public int GetPrice()
        {
            return this.Price;
        }

        public string GetName()
        {
            return this.Name;
        }

    }
}
