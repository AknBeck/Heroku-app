using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheReddit.Entities;
using TheReddit.Interfaces;
using TheReddit.Models;
using TheReddit.Services;

namespace TheReddit.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {

        public IPostService postService;
        public UserDBService userService;

        public HomeController(IPostService postService, UserDBService userService)
        {
            this.postService = postService;
            this.userService = userService;
        }

        [HttpGet("MainPage")]
        public IActionResult Index()
        {
            var model = new UserPostViewModel(postService.GetAllPosts());
            return View(model);
        }
        [HttpGet("AddPost")]
        public IActionResult AddPost()
        {
            var model = new UserPostViewModel();
            return View(model);
        }
        [HttpPost("AddPost")]
        public IActionResult AddPost(Post post)
        {
            postService.CreatePost(post);
            return RedirectToAction("Index");
        }
        [HttpGet("Rating")]
        public IActionResult RatingUpOrDown(long incOrDec, long id)
        {
            postService.RatingUpOrDown(incOrDec, id);
            return RedirectToAction("Index");
        }
        [HttpGet("Registration")]
        public IActionResult Registration(bool input = true)
        {
            var model = new UserPostViewModel(input);
            return View(model);
        }
        [HttpPost("Registration")]
        public IActionResult Registration(User user)
        {
            var isSuccess = userService.CreateUser(user);
            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Registration", new { input = isSuccess });
            };
        }
        /*[HttpPost("Login")]
        public IActionResult Login(User user)
        {
            userService.Login(user);
        }*/
    }
}