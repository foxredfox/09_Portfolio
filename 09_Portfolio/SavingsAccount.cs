using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class SavingsAccount : Asset
    {
        public double InterestRate{ get; set;}
        public double Value{ get; set;}
        public String AccountID{ get; set;}

        public SavingsAccount(){}
        public SavingsAccount(String AccountID, double Value, double InterestRate)
        {
            this.AccountID    = AccountID;
            this.Value        = Value;
            this.InterestRate = InterestRate;
        }
        
        public double GetValue()
        {
            return Value;
        }

        public override String ToString()
        {
            return 
                "SavingsAccount[value="+ Value.ToString("F1").Replace(',', '.') +
                ",interestRate="+ InterestRate.ToString("F1").Replace(',', '.')+ "]";
        }

        public void ApplyInterest()
        {
            Value += Value * (InterestRate / 100);
        }

        public static double TotalValue(Asset[] accounts)
        {
            return accounts.Sum(account => account.GetValue());
        }
    }
}
