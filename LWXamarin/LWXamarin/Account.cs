using System;
using System.Collections.Generic;
using System.Text;

namespace LWXamarin
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? ReconciledBalance { get; set; }
        public decimal LowBalanceWarning { get; set; }
        public DateTime Created { get; set; }
        public int HouseholdId { get; set; }
    }
}
