using NTMobileApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
