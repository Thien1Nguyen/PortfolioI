using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet("")] 
    [HttpGet("index")] 
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("Project")] 
    public ViewResult Project()
    {
        return View("Project");
    }

    [HttpGet("Contact")] 
    public ViewResult Contact()
    {
        return View("Contact");
    }
    
}