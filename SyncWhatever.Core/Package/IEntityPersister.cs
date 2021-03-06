namespace SyncWhatever.Core.Package
{
    public interface IEntityPersister<in TSource, in TTarget>
    {
        string Insert(TSource source);
        string Update(TSource source, TTarget target);
        void Delete(TTarget target);
    }
}