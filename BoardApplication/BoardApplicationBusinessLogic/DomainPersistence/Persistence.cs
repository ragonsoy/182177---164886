﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic.DomainPersistence
{
    public class Persistence
    {
        List<Object> collection;
        public Persistence()
        {
            collection = new List<Object>();
        }

        public void Add(Object obj)
        {
            collection.Add(obj);
        }

        public void Remove(Object obj)
        {
            collection.Remove(obj);
        }

        public Object Get(Object obj)
        {
            Object objectReturn = new Object();
            foreach (var item in collection)
            {               
                if (base.Equals(obj))
                    objectReturn = item;
            }
            return objectReturn;
        }

        public int ElementsCount()
        {
            return collection.Count();
        }

        public bool ElementExist(Object obj)
        {
            return collection.Contains(obj);
        }
    }
}
