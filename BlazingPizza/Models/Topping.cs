﻿using BlazingPizza.Extensions;

namespace BlazingPizza.Models;

public record Topping
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string GetFormattedPrice() => Price.ToFormattedPrice();
}
