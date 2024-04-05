using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demoweb.Models;
using Microsoft.Data.SqlClient;

namespace demoweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Searchbar()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Contactus()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // SqlConnection con = new SqlConnection();
        // SqlCommand cmd = new SqlCommand();
        // SqlDataReader? dr;

        // void connectionString()
        // {
        //     con.ConnectionString = "data source=192.168.1.240\\SQLEXPRESS; database=demoweb; User Id=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True;";
        // }

        // [HttpPost]
        // public IActionResult verifylogin(LoginViewModel lmodel)
        // {
        //     connectionString();
        //     con.Open();
        //     cmd.Connection = con;
        //      cmd.CommandText = "select * from User_login_table where email=@Email and password=@Password;";
        //     cmd.Parameters.AddWithValue("@Email", lmodel.email);
        //     cmd.Parameters.AddWithValue("@Password", lmodel.password);

        //     _logger.LogInformation("Email data : " + lmodel.email + " pass data :" + lmodel.password);
        //     // cmd.CommandText = cmd.CommandText = "select * from User_login_table where userid='" + lmodel.userid + "' and email='" + lmodel.email + "' and password='" + lmodel.password + "';";

        //     dr = cmd.ExecuteReader();

            // if (dr.Read())
            // {
            //     _logger.LogInformation("data insde dr read"+"Email data" + lmodel.email + " pass data" + lmodel.password);
            //     if (lmodel.email=="admin")
            //     {
            //         return View("Register", "Home");
            //     }
                // else if (lmodel.email == "agent")
                // {
                //     return RedirectToAction("Index", "Home");
                // }
                // else
                // {
                //     con.Close();
                //     return View("Error");
                // }
            // }
            // else
            // {
            //     con.Close();
            //     return View("Error");
            // }
        // }

        public IActionResult Register()
        {
            return View();
        }

       public IActionResult Error()
{
    string requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    var errorViewModel = new ErrorViewModel { RequestId = requestId };
    return View(errorViewModel);
}

    }
}
