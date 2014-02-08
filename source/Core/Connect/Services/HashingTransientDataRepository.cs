﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Connect.Services
{
    public class HashingTransientDataRepository<T> : ITransientDataRepository<T>
    {
        ITransientDataRepository<T> inner;
        public HashingTransientDataRepository(ITransientDataRepository<T> inner)
        {
            this.inner = inner;
        }

        private string Hash(string key)
        {
            return key;
        }

        public void Store(string key, T value)
        {
            key = Hash(key);
            inner.Store(key, value);
        }

        public T Get(string key)
        {
            key = Hash(key);
            return inner.Get(key);
        }

        public void Remove(string key)
        {
            key = Hash(key);
            inner.Remove(key);
        }
    }
}