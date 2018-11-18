using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QTApi.DAL;
using QTApi.Helpers;
using QTApi.Models;

namespace QTApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalFactsController : ControllerBase
    {
        private readonly APIContext _context;

        public AnimalFactsController(APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            //FactsDatabase fact = new FactsDatabase(_context);
            //fact.FactsToDatabse();
            return Ok();
        }

        [HttpGet("{animal}/{id}")]
        public IActionResult Get(string animal, int id)
        {
            try
            {
                switch (animal)
                {
                    case "cat":
                        var catFact = _context.CatFacts.Find(id);
                        if (catFact == null) { return NotFound(); }
                        return new OkObjectResult(catFact);
                    case "dog":
                        var dogFact = _context.DogFacts.Find(id);
                        if (dogFact == null) { return NotFound(); }
                        return new OkObjectResult(dogFact);
                    case "sloth":
                        var slothFact = _context.SlothFacts.Find(id);
                        if (slothFact == null) { return NotFound(); }
                        return new OkObjectResult(slothFact);
                    case "cow":
                        var cowFact = _context.CowFacts.Find(id);
                        if (cowFact == null) { return NotFound(); }
                        return new OkObjectResult(cowFact);
                    case "crow":
                        var crowFact = _context.CrowFacts.Find(id);
                        if (crowFact == null) { return NotFound(); }
                        return new OkObjectResult(crowFact);
                    case "elephant":
                        var elephantFact = _context.ElephantFacts.Find(id);
                        if (elephantFact == null) { return NotFound(); }
                        return new OkObjectResult(elephantFact);
                    case "jellyfish":
                        var jellyfishFact = _context.JellyfishFacts.Find(id);
                        if (jellyfishFact == null) { return NotFound(); }
                        return new OkObjectResult(jellyfishFact);
                    case "mantisshrimp":
                        var mantisshrimpFact = _context.MantisShrimpFacts.Find(id);
                        if (mantisshrimpFact == null) { return NotFound(); }
                        return new OkObjectResult(mantisshrimpFact);
                    default:
                        return NotFound();
                }
            }
            catch
            {
                return StatusCode(500);
            }
            
        }

        [HttpGet("{animal}/random/{count}")]
        public IActionResult RandomGet(string animal, int count)
        {
            try
            {
                Random rand = new Random();
                switch (animal)
                {
                    case "cat":
                        var catFact = _context.CatFacts.OrderBy(f => rand.Next()).Take(count);
                        if (catFact == null) { return NotFound(); }
                        return new OkObjectResult(catFact);
                    case "dog":
                        var dogFact = _context.DogFacts.OrderBy(f => rand.Next()).Take(count);
                        if (dogFact == null) { return NotFound(); }
                        return new OkObjectResult(dogFact);
                    case "sloth":
                        var slothFact = _context.SlothFacts.OrderBy(f => rand.Next()).Take(count);
                        if (slothFact == null) { return NotFound(); }
                        return new OkObjectResult(slothFact);
                    case "cow":
                        var cowFact = _context.CowFacts.OrderBy(f => rand.Next()).Take(count);
                        if (cowFact == null) { return NotFound(); }
                        return new OkObjectResult(cowFact);
                    case "crow":
                        var crowFact = _context.CrowFacts.OrderBy(f => rand.Next()).Take(count);
                        if (crowFact == null) { return NotFound(); }
                        return new OkObjectResult(crowFact);
                    case "elephant":
                        var elephantFact = _context.ElephantFacts.OrderBy(f => rand.Next()).Take(count);
                        if (elephantFact == null) { return NotFound(); }
                        return new OkObjectResult(elephantFact);
                    case "jellyfish":
                        var jellyfishFact = _context.JellyfishFacts.OrderBy(f => rand.Next()).Take(count);
                        if (jellyfishFact == null) { return NotFound(); }
                        return new OkObjectResult(jellyfishFact);
                    case "mantisshrimp":
                        var mantisshrimpFact = _context.MantisShrimpFacts.OrderBy(f => rand.Next()).Take(count);
                        if (mantisshrimpFact == null) { return NotFound(); }
                        return new OkObjectResult(mantisshrimpFact);
                    default:
                        return NotFound();
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}