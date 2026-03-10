using System;
using System.Collections.Generic;
using System.Text;

namespace Magazine.Core.Models
{
    internal class Product
    {
        public Guid Id { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; } // пусть будет тут путь до изображения
    }
}
