using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiAssistant.Core.Entities
{
    public class Error : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Solution1 { get; set; }
        public byte[]? SolutionPhoto1 { get; set; }
        public int ErrorCategoryId { get; set; }
        public ErrorCategory ErrorCategory { get; set; }
    }
}