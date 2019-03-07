using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            return View();
        }

        public string ShowAuthor()
        {
            return "Nguyen Vinh Tri";
        }

        public double Factorial(int n)
        {
            
            double result = 1;
            for (int i = 1; i < n; i++)
            {
                result = result * i;
            }

            return result;
        }

        public int Sum(int a, int b)
        {
            int result = 0;
            return result = a + b;

        }
	}
}