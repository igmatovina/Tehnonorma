using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tehno.WebSite.Pages
{
    public class NamaModel : PageModel
    {
        private readonly ILogger<NamaModel> _logger;

        public NamaModel(ILogger<NamaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
