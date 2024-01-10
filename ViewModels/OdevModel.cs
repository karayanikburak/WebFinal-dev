﻿namespace WebFinal.ViewModels
{
    public class OdevModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public CategoryModel Category { get; set; }

    }
}
