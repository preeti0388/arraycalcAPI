using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PreetiArrayAPI.Interface;

namespace PreetiArrayAPI.Controllers
{
    [Route("api/[controller]")]
    public class ArrayCalcController : Controller
    {
        private readonly IArrayManipulation _arrayManipulationService;

        public ArrayCalcController(IArrayManipulation arrayManipulationService)
        {
            _arrayManipulationService = arrayManipulationService;
        }

       
        [HttpGet]
        public IActionResult GetHome()
        {
            return Ok("Array Calc API");
        }

        // Reverse Array
        [HttpGet("reverse")]
        public IActionResult GetReversed([FromQuery]string[] productIds)
        {
            try
            {
                var result = _arrayManipulationService.ReverseArray(productIds);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest("Error while reversing array: " + e.Message);
            }
        }

        //deletepart
        [HttpGet("deletepart")]
        public IActionResult GetDeleted([FromQuery]string position, [FromQuery]string[] productIds)
        {
            try
            {
                var result = _arrayManipulationService.DeleteArrayElement(productIds, position);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest("Error while deleteng element: " + e.Message);
            }
        }
    }
}
