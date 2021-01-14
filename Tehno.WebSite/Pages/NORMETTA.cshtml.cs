using Tehno.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tehno.WebSite.Models;

namespace Tehno.WebSite.Pages
{
    public class NORMETTAModel : PageModel
    {
        private readonly ILogger<NORMETTAModel> _logger;
        public JsonFileTorroService TorroService;
        public IEnumerable<Torro>Torros { get; private set; }

        public NORMETTAModel(ILogger<NORMETTAModel> logger,
            JsonFileTorroService torroService)
        {
            _logger = logger;
            TorroService = torroService;
        }

        public void OnGet()
    
        {
            Torros = TorroService.GetNORMETTA();

        }
    }
}
