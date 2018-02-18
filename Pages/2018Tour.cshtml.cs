using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EgeeioWebsite.Pages
{
    public class TourModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Let's kick off m00ch's 2018 Jimmy Johns Tour!!!";
        }
    }
}
