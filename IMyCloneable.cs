﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome8
{
    public interface IMyCloneable<T> where T : class
    {
        T Clone();
    }
}
