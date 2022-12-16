using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghitau_Emanuela_Lab2.Data;
using Ghitau_Emanuela_Lab2.Models;
using Ghitau_Emanuela_Lab2.Models.ViewModels;

namespace Ghitau_Emanuela_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Ghitau_Emanuela_Lab2.Data.Ghitau_Emanuela_Lab2Context _context;

        public IndexModel(Ghitau_Emanuela_Lab2.Data.Ghitau_Emanuela_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;
        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }


        public async Task OnGetAsync()
        {

        }

    }
}

