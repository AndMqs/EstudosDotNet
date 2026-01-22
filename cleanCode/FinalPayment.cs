using System;
using System.Collections.Generic;


public class FinalPayment
{
    public const double REGULAR_CLIENT_DISCOUNT = 0.05;
    public const double PREMIUM_CLIENT_DISCOUNT = 0.10;
    public const double VIP_CLIENT_DISCOUNT = 0.15;

    public double CalcFinalPayment(int quantity, double valueItem, CustomerType customerType, bool hasDiscount)
    {
        if (quantity <= 0 || valueItem <= 0)
            return 0;

        double total = TotalOrder(quantity, valueItem);
        return DiscountOrder(total, customerType, hasDiscount);
    }

    private static double TotalOrder(int quantity, double valueItem)
    {
        return quantity * valueItem;
    }

    private static double DiscountOrder(double total, CustomerType customerType, bool hasDiscount)
    {
        if (!hasDiscount)
            return total;

        double discountRate = 0;

        switch (customerType)
        {
            case CustomerType.Regular:
                discountRate = REGULAR_CLIENT_DISCOUNT;
                break;

            case CustomerType.Premium:
                discountRate = PREMIUM_CLIENT_DISCOUNT;
                break;

            case CustomerType.Vip:
                discountRate = VIP_CLIENT_DISCOUNT;
                break;
        }

        return total - (total * discountRate);
    }
}
