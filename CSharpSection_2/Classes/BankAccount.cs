using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSection_2.Classes
{
    public class BankAccount
    {
        private float balance;
        private string owner;
        public float Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }
        public BankAccount(float balance, string owner)
        {
            Balance = balance;
            this.owner = owner;
        }
        public virtual float AddBalance(float balancetoBeAdded)
        {
            Balance = balance + balancetoBeAdded;
            return Balance;
        }
        public virtual float AddBalance(float balancetoBeAdded, bool NegativeBalanace)
        {
            if (NegativeBalanace)
                balance = balance + balancetoBeAdded;
            else
                Balance = balance - balancetoBeAdded;
            return Balance;
        }
        public async Task<string> GetData()
        {
            Thread.Sleep(2000);
            return "Completed";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public string parent { get; set; }
        public ChildBankAccount(float balance, string owner, string parent): base(balance, owner)
        {
            this.parent = parent;
        }
        public override float AddBalance(float balancetoBeAdded)
        {
            if (balancetoBeAdded >= -10)
                return base.AddBalance(balancetoBeAdded);
            return Balance;
        }
        public override float AddBalance(float balancetoBeAdded, bool NegativeBalanace)
        {
            if (balancetoBeAdded >= -10)
                return base.AddBalance(balancetoBeAdded, NegativeBalanace);
            return Balance;
        }
    }
}
