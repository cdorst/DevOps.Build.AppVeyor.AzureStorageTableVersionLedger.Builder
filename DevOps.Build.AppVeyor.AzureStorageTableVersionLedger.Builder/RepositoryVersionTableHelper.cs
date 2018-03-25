// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder
{
    /// <summary>Function returns an instance of RepositoryVersionTable</summary>
    public static class RepositoryVersionTableHelper
    {
        /// <summary>Returns an instance of RepositoryVersionTable</summary>
        public static RepositoryVersionTable RepositoryVersionTableEntry(string accountName, string repositoryName, string version) => new RepositoryVersionTable(accountName, repositoryName, version);
    }
}
