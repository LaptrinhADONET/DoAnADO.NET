﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.IRepository
{
    public abstract class Repository<T> : IRepository<T>
    {
        private DBContect db = new DBContect();

        public abstract void Add(T obj);

        public abstract void Delete(T obj);

        public abstract List<T> Get_By_Top(string Top, string Where, string Order);

        public abstract void Update(T obj);
    }
}