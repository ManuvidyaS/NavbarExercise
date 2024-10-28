﻿using Microsoft.AspNetCore.Mvc;
using OurHero2_Day5.Model;
using OurHero2_Day5.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurHero2_Day5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurHeroController : ControllerBase
    {
        private readonly IOurHeroService _heroService;
        public OurHeroController(IOurHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? isActive = null)
        {
            var heros = await _heroService.GetAllHeros(isActive);
            return Ok(heros);
        }

        [HttpGet("{id}")]
        //[Route("{id}")] // /api/OurHero/:id
        public async Task<IActionResult> Get(int id)
        {
            var hero = await _heroService.GetHerosByID(id);
            if (hero == null)
            {
                return NotFound();
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUpdateOurHero heroObject)
        {
            var hero = await _heroService.AddOurHero(heroObject);

            if (hero == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = "Super Hero Created Successfully!!!",
                id = hero!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] AddUpdateOurHero heroObject)
        {
            var hero = await _heroService.UpdateOurHero(id, heroObject);
            if (hero == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Updated Successfully!!!",
                id = hero!.Id
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!await _heroService.DeleteHerosByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Deleted Successfully!!!",
                id = id
            });
        }
    }
}

