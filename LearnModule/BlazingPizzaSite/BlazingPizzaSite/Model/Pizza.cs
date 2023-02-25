﻿using System.Globalization;

namespace BlazingPizzaSite.Model;

/// <summary>
/// Represents a customized pizza as part of an order.
/// </summary>
public class Pizza
{
    public const int DefaultSize = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public int Id { get; set; }

    public int OrderId { get; set; }

    public PizzaSpecial Special { get; set; }

    public int SpecialId { get; set; }

    public int Size { get; set; }

    public List<PizzaTopping> Toppings { get; set; }

    public decimal GetBasePrice()
    {
        return Size / (decimal)DefaultSize * Special.BasePrice;
    }

    public decimal GetTotalPrice() => GetBasePrice();

    public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00", CultureInfo.CurrentCulture);
}