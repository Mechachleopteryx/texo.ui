﻿using System.Collections.Generic;
using BeaverSoft.Texo.Commands.NugetManager.Model.Packages;

namespace BeaverSoft.Texo.Commands.NugetManager.Services
{
    public interface IPackageManagementService
    {
        IPackageInfo Get(string packageId);

        IEnumerable<IPackageInfo> FindPackages(string searchTerm);

        void Clear();
    }
}
