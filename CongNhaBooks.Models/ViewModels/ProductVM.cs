using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CongNhaBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } // Displays all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; } // install package Microsoft.AspNetCore.Mvc
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

    }
}


