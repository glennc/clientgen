using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebClientCsharp.Pages
{
    public class IndexModel : PageModel
    {
        private MyClient _client;

        public IndexModel(MyClient client)
        {
            _client = client;
        }

        public async Task OnGet()
        {
            var values = await _client.GetAllAsync();
        }
    }
}
