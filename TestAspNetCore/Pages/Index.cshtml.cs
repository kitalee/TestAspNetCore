using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAspNetCore.Pages
{
    public class IndexModel : PageModel
    {
        public IHostingEnvironment _env;

        public IndexModel(IHostingEnvironment env)
        {
            _env = env;
        }
        public void OnGet()
        {
            ViewData["envName"] = _env.EnvironmentName;
        }
    }
}
