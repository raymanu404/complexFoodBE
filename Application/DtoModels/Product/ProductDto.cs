﻿using Domain.ValueObjects;
using Domain.Models.Enums;

namespace Application.DtoModels.Product
{
    public class ProductDto
    {
        public Categories Category { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }= null!;
        public float Price { get; set; }
        public string Image { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsInStock { get; set; }
    }
}
