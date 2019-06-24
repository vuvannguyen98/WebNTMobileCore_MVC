﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
