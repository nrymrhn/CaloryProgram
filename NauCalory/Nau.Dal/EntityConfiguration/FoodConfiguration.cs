﻿using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.EntityConfiguration
{
    public class FoodConfiguration : EntityTypeConfiguration<Food>
    {

        public FoodConfiguration()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.Grams).IsRequired();
            Property(c => c.Per100Cal).IsRequired();
            Property(c => c.CategoryID).IsRequired();
            Property(c => c.UserID).IsRequired();
            Property(c => c.PortionSize).IsRequired();
        }
    }
}
