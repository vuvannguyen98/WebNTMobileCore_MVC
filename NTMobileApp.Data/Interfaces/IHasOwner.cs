﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}
