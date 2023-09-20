using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();

        public RenderViewComponent() {
            MenuItems.Add(new MenuItem(1, "Branches", "Branches/List"));
            MenuItems.Add(new MenuItem(2, "Students", "Students/List"));
            MenuItems.Add(new MenuItem(3, "Subjects", "Subjects/List"));
            MenuItems.Add(new MenuItem(4, "Courses", "Courses/List"));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
