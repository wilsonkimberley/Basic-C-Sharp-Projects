using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTimeApp.Pages;

public class IndexModel : PageModel
{
    public DateTime ServerTime { get; set; }

    public void OnGet()
    {
        ServerTime = DateTime.Now;
    }
}
