using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStoreApplication.Repository
{
    public class QueryOption<T>
    {
        // public properties for sorting, filtering and paging
        public Expression<Func<T,object>> OrderBy { get; set; }
        public Expression<Func<T,bool>> Where { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        //public write-only property for includes private string array
        private string[] includes;
        public string Includes 
        { set=>includes=value.Replace("","").Split(','); }
        //public method that returns includes array
        public string[] GetIncludes() => includes ?? new string[0];
        //read-only properties
        public bool HasWhere => Where != null;
        public bool HasPaging => (PageNumber > 0 && PageSize > 0);
        public bool HasOrder => OrderBy != null;

    }
}
