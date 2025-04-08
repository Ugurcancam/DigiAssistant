using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiAssistant.Core.Entities
{
    public class ErrorCategory : BaseEntity
    {
       public string Name { get; set; }
       public List<Error> Errors { get; set; }
 
    }
}