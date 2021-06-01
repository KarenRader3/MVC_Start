using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index(int id)
    {
      return View();
    }

    public IActionResult IndexWithLayout()
    {
      return View();
    }

   
    
    public ViewResult Chart()
    {
      string[] ChartLabels = new string[] { "Biscuits", "Cream Puffs", "Popovers", "Quick Loaf Breads", "Yeast Bread" };
      int[] ChartData = new int[] { 15,60,60,75,40 };

      ChartModel Model = new ChartModel
      {
        ChartType = "bar",
        Labels = String.Join(",", ChartLabels.Select(d => "'" + d + "'")),
        Data = String.Join(",", ChartData.Select(d => d)),
        Title = "Common Bread Baking Times"
      };

      return View(Model);
    }
  }
}