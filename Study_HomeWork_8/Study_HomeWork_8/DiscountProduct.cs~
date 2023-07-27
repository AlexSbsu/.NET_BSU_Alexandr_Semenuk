using System;
namespace Study_HomeWork_8
{
    internal class DiscountProduct : Product
    {
        double discount;
        public double CurrentDiscount { get => discount; set => discount = value; }
        public override double Cost { get => base.Cost * discount * 0.01; protected set => base.Cost = value; }

        public DiscountProduct(string ttovar_name, string ttovar_descr, double ccost, double ddiscount)
        : base(ttovar_name, ttovar_descr, ccost)
        {
            discount = ddiscount;
        }
    }
}
