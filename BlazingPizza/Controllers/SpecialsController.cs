﻿using BlazingPizza.Data;
using BlazingPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
	private readonly PizzaStoreContext db;

	public SpecialsController(PizzaStoreContext db)
	{
		this.db = db;
	}

	[HttpGet]
	public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
		=> (await db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
}
