using System;
using System.Collections.Generic;

namespace teht2
{
    class CashRegister
    {
        static void Main(string[] args)
        {
            List<ITransaction> cashRegister = new List<ITransaction>();

            cashRegister.Add(new PaidWithCard("0001-0002", DateTime.Now, 78.95f));
            cashRegister.Add(new PaidWithCard("0002-0003", DateTime.Now, 45.65f));
            cashRegister.Add(new PaidWithCash(DateTime.Now, 100f));
            cashRegister.Add(new PaidWithCash(DateTime.Now, 50f));

            foreach (ITransaction payment in cashRegister)
            {
                Console.WriteLine(payment.ShowTransaction());
            }
            Console.WriteLine("Yhteensä maksettu kortilla: {0:C2}", PaidWithCard.ShowCash());
            Console.WriteLine("Yhteensä maksettu käteisellä: {0:C2}", PaidWithCash.ShowCash());

            Console.WriteLine("Päivän myynti yhteensä: {0:C2}", PaidWithCard.ShowCash() + PaidWithCash.ShowCash());
        }
    }
}
