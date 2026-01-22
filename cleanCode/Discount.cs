using System;


public class Discount
{
    public double FIVE_PORCENT_DISCOUNT = 0.95; 
    public double TEN_PORCENT_DISCOUNT = 0.90;
  
    public double CalculateDiscount(double totalOrder, CustomerType clientType)
    {
        if(clientType == CustomerType.Regular)
        {
          return totalOrder * FIVE_PORCENT_DISCOUNT;  
        } 
        else if(clientType == CustomerType.Premium)
        {
            return totalOrder * TEN_PORCENT_DISCOUNT ;
        } 

        return totalOrder * totalOrder;
    }
}
