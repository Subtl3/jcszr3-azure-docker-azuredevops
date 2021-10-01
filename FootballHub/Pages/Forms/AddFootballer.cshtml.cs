using FootballHub.Core.Models;
using FootballHub.Core.Services;
using FootballHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FootballHub.Pages.Forms
{
    public class AddFootballerModel : PageModel
    {
        [BindProperty]
        public FootballerModel Footballer { get; set; }

        private readonly IFootballerService _footballerService;

        public AddFootballerModel(IFootballerService footballerService)
        {
            _footballerService = footballerService;
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

            var footballer = new Footballer
            {
                Name = Footballer.Name,
                Surname = Footballer.Surname,
                Number = Footballer.Number,
                Position = Footballer.Position
            };

            _footballerService.AddNew(footballer);

            return RedirectToPage("/Forms/AddFootballer");
        }
    }
}
