using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_api.Models;

//using web_api.Models;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<product> prodlist = new List<product>
        {
            new product() { Name = "Iphone 15", Price = 1000 },
            new product() { Name = "Iphone 16", Price = 2000 },
            new product() { Name = "Iphone 17", Price = 3000 },
        };

        [HttpGet("GetAllProduct")]
        public async Task<List<product>> GetAllProduct()
        {
            return prodlist;
        }

        public UserController() { }

        [HttpGet("GetAllUsers")]
        public async Task<List<string>> GetAllUser()
        {
            return new List<string> { "User1", "User2", "User3" };
        }

        [HttpGet("GetAllUsers2")]
        public async Task<List<string>> GetAllUser2()
        {
            return new List<string> { "User11", "User22", "User33" };
        }

        [HttpPost("/AddProduct")]
        public async Task<IActionResult> AddProduct(product model)
        {
            prodlist.Add(model);
            return Ok("Successfully");
        }

        [HttpPut("EditProduct/{id}")]
        public async Task<IActionResult> EditProduct([FromRoute] Guid id, product model)
        {
            // Request.RouteValues["id"]
            product? prodEdit = prodlist.Find(pro => pro.Id == id);
            if (prodEdit == null)
            {
                return NotFound("Không tìm thấy");
            }
            prodEdit.Name = model.Name;
            prodEdit.Price = model.Price;

            return Ok("Edit Ok");
        }

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            product? prodDel = prodlist.Find(pro => pro.Id == id);
            if (prodDel == null)
            {
                return NotFound("Không tìm thấy");
            }
            prodlist.Remove(prodDel);
            return Ok("xoa Ok");
        }
    }
}
