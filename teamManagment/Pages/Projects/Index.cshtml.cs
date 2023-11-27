using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using teamManagment.Data;
using teamManagment.Models;

namespace teamManagment.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly teamManagment.Data.teamManagmentContext _context;

        public IndexModel(teamManagment.Data.teamManagmentContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Project != null)
            {
                Project = await _context.Project.ToListAsync();
            }
        }
    }
}
