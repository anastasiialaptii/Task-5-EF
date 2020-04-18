using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task5_EF.Models;

namespace Task5_EF.Managers
{
    public class StatusTableManager
    {
        public void statusConstraint(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusModel>()
                .Property(p => p.Name)
                .HasMaxLength(30);
        }
    }
}