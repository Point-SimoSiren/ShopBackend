using System;
using System.Collections.Generic;

namespace ShopBackend.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Img { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
