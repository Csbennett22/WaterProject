using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WaterProject.infrastructure;
using WaterProject.Models;

namespace WaterProject.Pages
{
    public class DonateModel : PageModel
    {
        private IWaterProjectRepository repo { get; set; }
        public Basket basket { get; set; }
        public DonateModel (IWaterProjectRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int projectId, string returnUrl)
        {
            Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();

            basket.AddItem(p, 1);

            //HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int projectId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Project.ProjectId == projectId).Project);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
