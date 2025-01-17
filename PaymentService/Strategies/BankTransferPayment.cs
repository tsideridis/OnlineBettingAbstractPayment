﻿namespace PaymentService.Strategies;

//Naming convention: <PaymentMethod>Payment
public class BankTransferPayment :PaymentMethodBase
{
    protected override void ProcessPaymentCore(decimal amount)
    {
        Console.WriteLine($"Processing bank transfer payment for {amount}");
    }
}