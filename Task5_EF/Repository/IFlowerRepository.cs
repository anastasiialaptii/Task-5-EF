using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5_EF.Models;

namespace Task5_EF.Repository
{
    public interface IFlowerRepository
    {
        IEnumerable GetFlowers();

        FlowerModel GetFlowerById(int flowerId);

        void InsertFlower(FlowerModel flower);

        void UpdateFlower(int flowerId);

        void DeleteFlower(FlowerModel flower);

        void Save();

    }
}
