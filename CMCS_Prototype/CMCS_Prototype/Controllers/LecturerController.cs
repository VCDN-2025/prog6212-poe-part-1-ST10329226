using Microsoft.AspNetCore.Mvc;

// This controller handles the pages specific to the Lecturer role
public class LecturerController : Controller
{
    // the main Lecturer Dashboard view
    public IActionResult Dashboard()
    {
        //tells the MVC framework to look in Views/Lecturer/Dashboard.cshtml
        return View();
    }
    //Claim Submission Form view
    public IActionResult SubmitClaim()
    {
        // This tells the MVC framework to look in Views/Lecturer/SubmitClaim.cshtml
        return View();
    }
}