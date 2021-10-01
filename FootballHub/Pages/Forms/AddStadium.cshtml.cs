using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballHub.Core.Models;
using FootballHub.Core.Services;
using FootballHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FootballHub.Pages.Forms
{
    public class AddStadiumModel : PageModel
    {
        [BindProperty]
        public StadiumModel Stadium { get; set; }

        private readonly IStadiumService _stadiumService;

        public AddStadiumModel(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
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

            var stadium = new Stadium(Stadium.Name, Stadium.Capacity);

            _stadiumService.Add(stadium);

            return RedirectToPage("/Forms/AddStadium");
        }
    }
}
