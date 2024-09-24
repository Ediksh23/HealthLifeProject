using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Entities;

namespace HealthLifeProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
       /* private List<NavagateLink> _navs = null;
        public NavigationMenuViewComponent()
        {
            _navs = new List<NavagateLink>()
            {
                new NavagateLink { Id = 1, Href = "/", Title = "Головна", Childs = null, Order = 1, ParentId = null },
                new NavagateLink { Id = 2, Href = "/about/index", Title = "Про нас", Childs = null, Order = 1, ParentId = null },
                new NavagateLink { Id = 3, Href = "/about/index", Title = "Пацієнти", Childs = null, Order = 1, ParentId = null },
                new NavagateLink { Id = 4, Href = "/about/index", Title = "Категорії", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 5, Href = "/about/index", Title = "Напрямок лікування", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 6, Href = "/about/index", Title = "Стать", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 7, Href = "/about/index", Title = "Міста", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 8, Href = "/about/index", Title = "Медичні установи", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 9, Href = "/about/index", Title = "Відділення", Childs = null, Order = 2, ParentId = 3 },
                new NavagateLink { Id = 10, Href = "/about/index", Title = "Діагнози", Childs = null, Order = 3, ParentId = 9 },
                new NavagateLink { Id = 11, Href = "/about/index", Title = "Медичні установи", Childs = null, Order = 1, ParentId = null }
            };
        }
        public IViewComponentResult Invoke()
        {
            return View("NavigationMenu", _navs);
        }*/
    }
}
