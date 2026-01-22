

//Discount discount = new Discount();
//double totalRegular = discount.CalculateDiscount(100, CustomerType.Regular);
//        Console.WriteLine($"Valor desconto Cliente Regular: R$ {totalRegular:F2}");



FinalPayment pgm = new FinalPayment();

double resultado1 = pgm.CalcFinalPayment(2, 600.00, CustomerType.Regular, true);
Console.WriteLine($"Desconto CLiente Regular: {resultado1}");

double resultado2 = pmg.CalcFinalPayment(2, 500.00, CustomerType.Vip, true);
Console.WriteLine($" Sem desconto CLiente Vip: {resultado2}");





