using FBConvApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBConvApi.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public int FormAction(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return 1;
            }
            else
                return 0;
        }
    }

}
