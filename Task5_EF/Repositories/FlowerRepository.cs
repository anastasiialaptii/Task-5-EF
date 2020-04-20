﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class FlowerRepository : IRepository<FlowerModel>
    {
        private SupplyContext supplyDbContext;
        public FlowerRepository(SupplyContext dbContext)
        {
            supplyDbContext = dbContext;
        }

        public void Create(FlowerModel item)
        {
            supplyDbContext.Flowers.Add(item);
        }

        public void Delete(FlowerModel item)
        {
            supplyDbContext.Flowers.Remove(supplyDbContext.Flowers.Find(item.Id));
        }

        public List<FlowerModel> GetAll()
        {
            return supplyDbContext.Flowers.ToList();
        }

        public FlowerModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FlowerModel item)
        {
            supplyDbContext.Entry(item).State = EntityState.Modified;
        }
    }
}