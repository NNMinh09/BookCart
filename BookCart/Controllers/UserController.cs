using BookCart.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCart.Controllers
{
    public class UserController : Controller
    {
        readonly BookCartDbContext _ctx;
        public UserController(BookCartDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var users = _ctx.Users.ToListAsync();
            return View(users);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(UserController user)
        {
            if (ModelState.IsValid)
            {
                await _ctx.Users.AddAsync(user);
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
