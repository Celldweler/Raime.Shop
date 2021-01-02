using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.CreateProducts;
using Shop.Application.GetProducts;
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

        [BindProperty]
        public Shop.Application.CreateProducts.ProductViewModel Product { get; set; }
        
        public IEnumerable<Shop.Application.GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetPropucts(_ctx).Do();
        }
        public async Task<IActionResult> OnPost()
        {
            await new  CreatePropuct(_ctx).Do(Product);

            return RedirectToPage("Index");
        }
    }
}
