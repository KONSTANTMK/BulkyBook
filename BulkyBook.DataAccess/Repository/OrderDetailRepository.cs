﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetailModel>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;


        public OrderDetailRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }


        public void Update(OrderDetailModel obj)
        {
            _db.OrderDetail.Update(obj);
        }
    }
}
