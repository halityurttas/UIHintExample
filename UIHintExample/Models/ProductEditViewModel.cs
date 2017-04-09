using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UIHintExample.Models
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [UIHint("EditorAsTextArea")]
        public string Description { get; set; }
        [UIHint("Price2Percent")]
        public decimal Price { get; set; }
    }
}