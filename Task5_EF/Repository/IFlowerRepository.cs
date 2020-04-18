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

        void InsertFlower(int flowerId);

        void UpdateFlower(int flowerId);

        void DeleteFlower(int flowerId);

        void Save();

    }
}
