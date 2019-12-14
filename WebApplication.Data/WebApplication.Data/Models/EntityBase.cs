using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Data.Models
{
    public class EntityBase<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
