using Microsoft.AspNetCore.Mvc;

public class CartViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        int cartCount = 3;

        return View(cartCount);
    }
}