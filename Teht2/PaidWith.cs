using System;

namespace teht2
{
    class PaidWithCash : ITransaction
    {
        private static float TotalMoney = 0;
        private DateTime Date;
        private float Amount;

        public PaidWithCash(DateTime date, float amount)
        {
            this.Date = date;
            this.Amount = amount;
            TotalMoney += amount;
        }
        
        public float GetAmount()
        {
            return Amount;
        }

        public string ShowTransaction()
        {
            return string.Format("Maksettu käteisellä {0} {1:C2}", Date.ToShortDateString(), Amount);
        }

        public static float ShowCash()
        {
            return TotalMoney;
        }
    }

    class PaidWithCard : ITransaction
    {
        private static float TotalMoney = 0;
        private string CardNumber;
        private DateTime Date;
        private float Amount;

        public PaidWithCard(string card, DateTime date, float amount)
        {
            this.CardNumber = card;
            this.Date = date;
            this.Amount = amount;
            TotalMoney += amount;
        }

        public float GetAmount()
        {
            return Amount;
        }

        public string ShowTransaction()
        {
            return string.Format("Maksettu kortilla: {0}, {1}, {2:C2}", CardNumber, Date.ToShortDateString(), Amount);
        }

        public static float ShowCash()
        {
            return TotalMoney;
        }
    }
}
