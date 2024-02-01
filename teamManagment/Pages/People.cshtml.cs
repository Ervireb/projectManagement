using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;
using System;
using Microsoft.AspNetCore.Authorization;

namespace teamManagment.Pages
{
    [Authorize]
    public class loginModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

