using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class BankAcc
    {
        public string Owner { get; set; }
        public Guid AccNum { get; set; }
        public decimal Balance { get; set; }

        public BankAcc(string Owner)
        {
            this.Owner = Owner;
            this.AccNum = Guid.NewGuid();
            this.Balance = 0;
        }
    }
}
