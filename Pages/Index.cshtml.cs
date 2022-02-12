using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using razorwebEF.Model;

namespace razorwebEF.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly BlogDbConText _blogDbConText;

        public List<Article> posts { set; get; }

        public IndexModel(ILogger<IndexModel> logger, BlogDbConText blogDbConText)
        {
            _logger = logger;
            _blogDbConText = blogDbConText;
        }

        public void OnGet()
        {
            posts = (from p in _blogDbConText.article
                     orderby p.CreatedDated descending
                     select p).ToList();
        }
    }
}
