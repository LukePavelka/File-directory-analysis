using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PUXdesign.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PUXdesign.Analysis;

namespace PUXdesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RequestAndReportSingle RequestAnalyze, string submit)
        {
            if (submit == "Clear")
            {
                return View();
            }
            else if (submit == "Send request")
            {
                var FileAnalyzer = new FileAnalyzer(RequestAnalyze.Request.Path);
                if (FileAnalyzer.IsPathValid)
                {
                    FileAnalyzer.Run();
                    ReportFilesAnalyzer ReportFiles = FileAnalyzer.GetResult();
                    RequestAnalyze.Report = ReportFiles;
                    return View(RequestAnalyze);
                }
                else
                {
                    RequestAnalyze.Request.PathNotValid = true;
                    RequestAnalyze.Report = null;
                    return View(RequestAnalyze);
                }
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
