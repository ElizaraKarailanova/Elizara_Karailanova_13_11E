﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IDb<T,K>
    {
        void Create(T item);

        T Read(K key);

        List<T> ReadAll();

        void Update(T item);

        void Delete(K key);
    }
}