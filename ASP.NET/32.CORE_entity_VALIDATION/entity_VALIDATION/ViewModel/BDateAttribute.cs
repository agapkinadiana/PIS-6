using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace entity_VALIDATION.ViewModel
{
    public class BDateAttribute: ValidationAttribute
    {
        int maxAge = 100;

        public override bool IsValid(object value)
        {
            return (int)value > maxAge ? false : true; 
        }
    }
}
