using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIWithEF.Models;
using HandsOnAPIWithEF.Repositories;
namespace HandsOnAPIWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository repo;
        public ProductController(IProductRepository _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetProducts()
        {
            try
            {
                List<Products> list = repo.GetAll();
                return Ok(list);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
           try
            {
                Products p = repo.Get(id);
                if (p == null)
                    return NotFound("Invalid Id");
                else
                    return Ok(p);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Products item)
        {
           try
            {
                repo.Add(item);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
           try
            {
                repo.Delete(id);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Products item)
        {
           
            try
            {
                repo.Update(item);
                return Ok("Record Updated");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
      
    }
}
