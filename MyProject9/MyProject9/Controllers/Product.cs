using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using MyProject9.Dbcontext;
using MyProject9.Entities;
using MyProject9.Models;

namespace MyProject9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Product : ControllerBase
    {
        private readonly Orders dbContext;


        public Product(Orders dbContext)
        {
            this.dbContext = dbContext;
        }

       
        //private readonly ILogger<product> _logger;

        //public Product(ILogger<product> logger)
        //{
        //    _logger = logger;
        //}



        [HttpGet]
        public async Task<IActionResult> GetdetailsAsync()
        {
            //_logger.LogInformation("the orders were viewed");
            return Ok(await dbContext.products.ToListAsync());



        }

        [HttpGet]
        [Route("{id}")]

        public async Task<IActionResult> GetdetailsAsync([FromRoute] int id)
        {
            var products = await dbContext.products.FindAsync(id);

            if (products == null)
                return NotFound();

            return Ok(products);
        }


        [HttpPost]
        public async Task<IActionResult> Adddetails(Products addprodata)
        {
            var products = new product()
            {
               
                code = addprodata.code,
                name = addprodata.name,
                price = addprodata.price,

            };

            await dbContext.products.AddAsync(products);
            await dbContext.SaveChangesAsync();

            return Ok(products);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateDetails([FromRoute] int id, updateproduct updateproduct)
        {
            var products = await dbContext.products.FindAsync(id);

            if (products != null)
            {
                products.code = updateproduct.code;
                products.name = updateproduct.name;
                products.price = updateproduct.price;
               

                await dbContext.SaveChangesAsync();

                return Ok(products);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDetail([FromRoute] int id)
        {
            var products = await dbContext.products.FindAsync(id);

            if (products != null)
            {
                dbContext.Remove(products);
                await dbContext.SaveChangesAsync();
                return Ok(products);
            }
            return NotFound();
        }
    }
}


