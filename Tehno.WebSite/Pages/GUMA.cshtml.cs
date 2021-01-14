﻿using Tehno.WebSite.Services;
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
    public class GUMAModel : PageModel
    {
        private readonly ILogger<GUMAModel> _logger;
        public JsonFileTorroService TorroService;
        public IEnumerable<Torro>Torros { get; private set; }

        public GUMAModel(ILogger<GUMAModel> logger,
            JsonFileTorroService torroService)
        {
            _logger = logger;
            TorroService = torroService;
        }

        public void OnGet()
    
        {
            Torros = TorroService.GetGUMA();

        }
    }
}
