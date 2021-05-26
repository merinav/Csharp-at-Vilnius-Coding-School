using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class DebugController : Controller
    {
        public string Test()
        {
            return "Hello World";
        }

        public string GetParameter(int id) 
        {
            return "I got id: " + id;
        }
    }
}
