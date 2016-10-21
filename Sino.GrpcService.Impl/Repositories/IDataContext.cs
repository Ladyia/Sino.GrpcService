using MongoDB.Driver;

namespace Sino.GrpcService.Repositories
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public interface IDataContext
    {
        IMongoDatabase Database { get; set; }
    }
}
