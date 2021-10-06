using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class Person_VTA719 : Controller
    {
        // 
        // GET: /Person_VTA719/

        public string PersonID()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Person_VTA719/Welcome/ 

        public string PersonName()
        {
            return "This is the Welcome action method...";
        }
    }
}