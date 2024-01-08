using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts
{
    public class Paged<T>
    {
        public List<T>? Items { get; set; }
        
        public string? Keyword { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }

        public bool? IsActive { get; set; }
        public int PageCount { 
            get 
            { 
                if(TotalItems == null)
                {
                    return 0;
                }

                var quotient = Convert.ToInt32(Math.Floor(Convert.ToDecimal(TotalItems!.Value / PageSize!.Value))); 
                var mod = TotalItems!.Value % PageSize!.Value;

                return quotient * mod;
            } 
        }
        public int? TotalItems { get; set;}

    }
}
