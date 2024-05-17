namespace DemoWebApi.Common.Entities.Base
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
