using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
namespace WebApp.ViewModels
{
    public class CreateBookViewModel
    {
        public Book Book { get; set; } = null!;

        [ValidateNever]

        public SelectList Categories { get; set; } = null!;
    }
}
 