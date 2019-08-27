﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course1.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name + " $" + totalPrice() + "(Custom Fee: $ " + CustomsFee + ")";
        }
    }
}
