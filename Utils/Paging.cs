using System;
namespace razorwebEF.Utils
{
    public class Paging
    {
        public int currentPage { set; get; }

        public int countPages { set; get; }

        public Func<int?, string> UrlGenerator { set; get; }
    }
}
