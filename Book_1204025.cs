using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204025
{
    public class Book_1204025 : Product_1204025
    {
        protected string pageCount;

       public Book_1204025(string mytype, string mytitle, string pagecount) : base(mytype,mytitle)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get {
                return pageCount;
            }
            set{
               pageCount = value;
            }
        }

    }
}