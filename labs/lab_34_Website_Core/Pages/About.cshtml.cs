using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_34_Website_Core.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public string Message2 { get; set; }
        public int Num01 { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
            Message2 = "hey";
        }
    }



}
