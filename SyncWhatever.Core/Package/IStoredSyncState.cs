namespace SyncWhatever.Core.Package
{
    public interface IStoredSyncState : ISyncState
    {
        string Context { get; set; }
    }
}