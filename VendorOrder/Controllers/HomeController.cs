using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers {
  public class HomeController : Controller {
    [Route("/")]  // root directory path
    public ActionResult Index() { return View(); }
    
    [Route("/page-name-decorator")] // The route decorator is overriding the default URL path
    public string Hello() { return "Sup"; }
    
    [Route("/pagename")]
    public ActionResult PageName(string variable)  // delcare expected variables
    {
      ClassName myVariable = new ClassName();
      myVariable.Variable = variable;
      return View(myVariable);
    }
  }
}