using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElIncome
    {
        public int IncomeId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string SelfIncome { get; set; }
        public string DependentIncome { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
