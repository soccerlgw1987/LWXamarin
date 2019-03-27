using System;
using System.Collections.Generic;
using System.Text;

namespace LWXamarin
{
    public class Household
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decscription { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string AvatarPath { get; set; }
        public decimal IncomeAmount { get; set; }
        public decimal? CurrentBudgetAmount { get; set; }
    }
}
