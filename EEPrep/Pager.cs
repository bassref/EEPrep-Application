/**
 * Keep track of what question (page) that we are on.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    public class Pager
    {

        public int ItemCount { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }

        public bool HasPaging()
        {
           return PageSize > 0;
        }
        public bool HasNext()
        {
            // calculate the next page as if the page size  > 0 then the next
            // page is the # of items / page size
            
            double nextPage = HasPaging() ? (double)ItemCount / (double)PageSize : 0;
           return HasPaging() && (PageIndex + 1) < Math.Ceiling(nextPage);
        }

        public int GetPageCount()
        {
            // so if there aren't any page then we will not be 
            // using paging and then the page count is one
            return HasPaging() ? (int)Math.Ceiling(
                (double)ItemCount / (double)PageSize) : 1;
        }
}
}
