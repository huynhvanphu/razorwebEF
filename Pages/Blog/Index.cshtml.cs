using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorwebEF.Model;

namespace razorwebEF.Pages.Blog
{
    public class IndexModel : PageModel
    {
        //private readonly razorwebEF.Model.BlogDbConText _context;

        public List<Article> posts { set; get; }

        private const int ITEM_PER_PAGE = 10;

        [BindProperty(SupportsGet = true, Name = "p")]
        public int currentPage { set; get; }

        public int totalArticles { set; get; }

        public int totalPages { set; get; }

        private BlogDbConText _blogdbConText { set; get; }

        public IndexModel(razorwebEF.Model.BlogDbConText blogDbConText)
        {
            _blogdbConText = blogDbConText;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            //1.
            totalArticles = await _blogdbConText.article.CountAsync();

            //2.
            totalPages = (int)Math.Ceiling((double)totalArticles / ITEM_PER_PAGE);

            //3.
            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            //4.
            Article = await _blogdbConText.article
                            .OrderByDescending(a => a.CreatedDated)
                            .Skip((currentPage - 1)*ITEM_PER_PAGE)
                            .Take(ITEM_PER_PAGE)
                            .ToListAsync();
        }
    }
}
