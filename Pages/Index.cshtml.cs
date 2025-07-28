using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskHub.Models;

namespace TaskHub.Pages.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly TaskContext _context;

        public IndexModel(TaskContext context)
        {
            _context = context;
        }

        public List<TodoTask> TaskList { get; set; } = new();

        public async Task OnGetAsync()
        {
            TaskList = await _context.Tasks.ToListAsync();
        }
    }
}
