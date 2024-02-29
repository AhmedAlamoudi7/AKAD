
using ADEK.Core.Enums;

namespace ADEK.Core.Dtos
{
    public class Querys
    {
        public ActiveType? type { get; set; }
         public string? GeneralSearch { get; set; }
        public RoleTypes? RoleTypes { get; set; }
        public string? specialName { get; set; }
        public int? specialId { get; set; }
        public string? SpecialIds { get; set; }
        public string? DegreeIds { get; set; }
        public int? FinanceAccountId { get; set; }

    }
}
