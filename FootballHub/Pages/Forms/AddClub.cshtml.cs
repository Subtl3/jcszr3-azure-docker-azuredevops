using FootballHub.Core.Models;
using FootballHub.Core.Services;
using FootballHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FootballHub.Pages.Forms
{
    public class AddClubModel : PageModel
    {
        [BindProperty]
        public ClubModel Club { get; set; }

        private readonly IClubService _clubService;
        public AddClubModel(IClubService clubService)
        {
            _clubService = clubService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var club = new Club
            {
                League = Club.League,
                Name = Club.Name,
                YearFounded = Club.YearFounded
            };

            _clubService.AddNew(club);

            return RedirectToPage("/Index");
        }
    }
}
