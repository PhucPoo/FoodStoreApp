using Microsoft.AspNetCore.Mvc;
using FoodStoreApp.Models;
using System.Collections.Generic;

namespace FoodStoreApp.Controllers
{
    public class FoodController : Controller
    {
        // Giả lập cơ sở dữ liệu với danh sách món ăn
        private static List<FoodItem> _foodItems = new List<FoodItem>
        {
            new FoodItem { Id = 1, Name = "Pizza", Description = "Delicious cheese pizza", Price = 12.99m, ImageUrl = "/images/pizza.jpg" },
            new FoodItem { Id = 2, Name = "Burger", Description = "Juicy beef burger", Price = 8.99m, ImageUrl = "/images/burger.jpg" },
            new FoodItem { Id = 3, Name = "Pasta", Description = "Italian pasta with tomato sauce", Price = 10.99m, ImageUrl = "/images/pasta.jpg" }
        };

        public IActionResult Index()
        {
            return View(_foodItems); // Trả về danh sách món ăn
        }

        public IActionResult Details(int id)
        {
            var foodItem = _foodItems.Find(f => f.Id == id);
            if (foodItem == null)
            {
                return NotFound();
            }
            return View(foodItem); // Trả về chi tiết món ăn
        }
    }
}
