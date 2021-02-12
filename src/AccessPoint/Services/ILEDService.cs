﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessPoint.Services
{
    public partial interface ILEDService
    {
        Task SetAsync(int id, bool state);

        Task<bool> ToggleAsync(int id);
    }
}