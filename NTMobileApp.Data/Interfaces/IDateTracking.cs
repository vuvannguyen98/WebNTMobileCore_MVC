using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
