﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}
