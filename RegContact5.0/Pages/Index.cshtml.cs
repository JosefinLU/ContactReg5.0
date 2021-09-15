using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RegContact5._0.Models;
using RegContact5._0.Services;

namespace RegContact5._0.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileCompanyService CompanyService;

        public IEnumerable<Company> Companies { get; set; }


        public IndexModel(ILogger<IndexModel> logger, JsonFileCompanyService companyService)
        {
            _logger = logger;
            CompanyService = companyService;
        }

        public void OnGet()
        {
            Companies = CompanyService.GetCompany();
        }
    }
}
