﻿namespace SRRSBakery.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public string ImgUrl { get; set; }
    }
}