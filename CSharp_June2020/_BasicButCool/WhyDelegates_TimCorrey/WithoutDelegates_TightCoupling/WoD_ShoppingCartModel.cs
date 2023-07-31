﻿using System.Collections.Generic;
using System.Linq;

namespace CSharp_June2020._BasicButCool.Delegates
{
   public class WoD_ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount)
        {

            decimal subTotal = Items.Sum(x => x.Price);
            mentionDiscount(subTotal);

            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }
            else
            {
                return subTotal;
            }

        }
    }
}