using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task5_EF.Managers
{
    public class MyManager
    {
        public void Create()
        {
            using (var con = new SupplyContext())
            {
                con.Statuses.Add(new Models.StatusModel
                {
                    Id=1,
                    Name = "qwerty"
                });
                con.SaveChanges();
            }
        }
    }
}