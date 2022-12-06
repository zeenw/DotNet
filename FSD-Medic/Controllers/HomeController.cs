using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using FSD_Medic.Models;

namespace FSD_Medic.Controllers
{
    //[Route("[controller]")]
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        List<User> users = new List<User>();
        public HomeController()
        {
            User u0 = new User();
            u0.UserName = "Zeen";
            u0.Email = "zeen@gmail.com";
            users.Add(u0);

            User u1 = new User();
            u1.UserName = "Jia";
            u1.Email = "jia@gmail.com";
            users.Add(u1);

            User u2 = new User();
            u2.UserName = "Ling";
            u2.Email = "ling@gmail.com";
            users.Add(u2);

            User u3 = new User();
            u3.UserName = "Nagn";
            u3.Email = "nagn@gmail.com";
            users.Add(u3);

            User u4 = new User();
            u4.UserName = "Xuan";
            u4.Email = "xuan@gmail.com";
            users.Add(u4);
        }
        // GET: HomeController
        public List<User> Index()
        {
            return users;
        }

        // GET: HomeController/Details/5
        [Route("Details")]
        public ActionResult<User> Details(int id)
        {
            return users[id];
        }

        // POST: HomeController/Create
        [HttpPost]
        [Route("Create")]
        public ActionResult<User> Create(User user)
        {
            return user;
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [Route("Edit")]
        public ActionResult<User> Edit(int id, User user)
        {
            users[id] = user;
            return users[id];
        }

        // POST: HomeController/Delete/5
        [Route("Delete")]
        public ActionResult<User> Delete(int id)
        {
            return users[id];
        }


    }
}
