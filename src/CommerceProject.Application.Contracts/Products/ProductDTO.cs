using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CommerceProject.Categories
{
    public class ProductDTO : FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal price { get; set; }
    }
}
