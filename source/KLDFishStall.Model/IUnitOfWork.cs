using KLDFishStall.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLDFishStall.Model
{
    public interface IUnitOfWork
    {
        Repository<User> User { get; }
        Repository<Order> Order { get; }
        Repository<OrderItem> OrderItem { get; }
        Repository<FishAttributes> FishAttributes { get; }
        Repository<Fish> Fish { get; }
        Repository<Category> Category { get; }
        Repository<FishCategory> FishCategory { get; }
        Repository<FishImage> FishImage { get; }

        void Commit();
    }
}
