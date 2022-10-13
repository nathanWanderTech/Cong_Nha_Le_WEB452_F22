using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web452Assignment1.Models
{
    public class Bed
    {
        public Bed() {}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } // Image url
        public decimal Price { get; set; }
        public string Type { get; set; } = "Normal"; // default type. Other type: bunk bed, sofa bed
        public string Color { get; set; }
        public string Size { get; set; } // Queen, full, single
        public string Designer { get; set; }

        [Range(0, 5)]
        public int CustomerReview { get; set; }
    }
}

