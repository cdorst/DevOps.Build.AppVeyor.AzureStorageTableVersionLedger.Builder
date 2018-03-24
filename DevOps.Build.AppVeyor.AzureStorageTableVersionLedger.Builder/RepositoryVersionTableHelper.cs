namespace DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder
{
    /// <summary>Function returns an instance of RepositoryVersionTable</summary>
    public static class RepositoryVersionTableHelper
    {
        /// <summary>Returns an instance of RepositoryVersionTable</summary>
        public static RepositoryVersionTable RepositoryVersionTableEntry(string accountName, string repositoryName, string version) => new RepositoryVersionTable(accountName, repositoryName, version);
    }
}
