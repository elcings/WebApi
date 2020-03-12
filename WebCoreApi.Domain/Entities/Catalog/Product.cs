using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApi.Domain.Entities.BaseModel;

namespace WebCoreApi.Domain.Entities.Catalog
{
    public class Product: BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
