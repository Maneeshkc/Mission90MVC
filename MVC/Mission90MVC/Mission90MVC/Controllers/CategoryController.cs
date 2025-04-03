using Microsoft.AspNetCore.Mvc;
using Mission90.Dal.Models;
using Mission90.Dal.UnitOfWork;

namespace Mission90MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> items = _unitOfWork.Category.GetAll().ToList();
            return View(items);
        }
    }
}
