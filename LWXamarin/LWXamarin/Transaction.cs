using System;
using System.Collections.Generic;
using System.Text;

namespace LWXamarin
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public decimal Amount { get; set; }
        public decimal? ReconciledAmount { get; set; }
        public bool Reconciled { get; set; }
        public int AccountId { get; set; }
        public int? BudgetItemId { get; set; }
        public string EnteredById { get; set; }
    }
}
