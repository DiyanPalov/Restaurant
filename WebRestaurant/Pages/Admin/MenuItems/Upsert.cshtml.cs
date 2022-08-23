using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.DataAccess.Data;
using Restaurant.DataAccess.Repository.IRepository;
using Restaurant.Models;
using System.Linq;

namespace WebRestaurant.Pages.Admin.MenuItems;

[BindProperties]
public class UpsertModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public MenuItem MenuItem { get; set; }

    public IEnumerable<SelectListItem> CategoryList { get; set; }

    public IEnumerable<SelectListItem> FoodTypeList { get; set; }

    public UpsertModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        MenuItem = new();
    }

    public void OnGet()
    {
        CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem()
        {
            Text = i.Name,
            Value = i.Id.ToString()
        });

        FoodTypeList = _unitOfWork.FoodType.GetAll().Select(i => new SelectListItem()
        {
            Text = i.Name,
            Value = i.Id.ToString()
        });
    }

    public async Task<IActionResult> OnPost()
    {
      
        if (ModelState.IsValid)
        {
            _unitOfWork.FoodType.Add(FoodType);
            _unitOfWork.Save();
            TempData["success"] = "FoodType created successfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}