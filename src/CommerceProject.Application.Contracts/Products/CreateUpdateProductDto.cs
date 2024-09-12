using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CommerceProject.Categories
{
    public class CreateUpdateProductDto :EntityDto<int>
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal price { get; set; }
    }
}
