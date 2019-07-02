using crud_and_chart.Controllers;
using crud_and_chart.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_and_chart.ViewComponents
{
    public class CrudContentViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetItemsFromHomeController());
        }

        private List<Item> GetItemsFromHomeController() => HomeController.GetItemsInMemory();
    }
}
