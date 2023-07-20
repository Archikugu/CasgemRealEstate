﻿namespace RealEstate.Entities.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product>? Products { get; set; }
    }

}
