﻿using Domain.ValueObjects;
using Domain.Models.Enums;

namespace Domain.Models.Ordering;

public class OrderItem
{
    public int OrderItemId { get; set; }
    public Cantity Cantity { get; set; }
    public Categories Category { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Image { get; set; } = null!;
    public Price Price { get; set; }
    public int OrderId { get; set; }

}