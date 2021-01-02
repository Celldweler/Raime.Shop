using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
               
        public IEnumerable<GetPropucts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetPropucts(_ctx).Do();
        }        
    }
}
