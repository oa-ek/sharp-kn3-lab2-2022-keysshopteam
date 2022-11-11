using KeysShop.Core;
using KeysShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KeysShop.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrdersRepository ordersRepository;
        private readonly SessionManager sessionManager;
        public OrderController(OrdersRepository ordersRepository, SessionManager sessionManager)
        {
            this.ordersRepository = ordersRepository;
            this.sessionManager = sessionManager;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order, string paymethod)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("cart");
            order.Delivery = paymethod;
            if (cart.Count == 0) 
            {
                ModelState.AddModelError("","У корзині мають бути товари");
            }
            if(ModelState.IsValid)
            {
                ordersRepository.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення прийнято";
            return View();
        }
    }
}
