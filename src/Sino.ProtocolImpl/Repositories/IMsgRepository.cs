using Sino.GrpcService.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sino.GrpcService.Repositories
{
    /// <summary>
    /// 消息仓储
    /// </summary>
    public interface IMsgRepository
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        Task<List<MsgDM>> GetList(long userId, string title, long startTime, long endTime);

        /// <summary>
        /// 获取实体
        /// </summary>
        Task<MsgDM> Get(string id);

        /// <summary>
        /// 更新实体
        /// </summary>
        Task<bool> Update(MsgDM data);

        /// <summary>
        /// 添加实体
        /// </summary>
        Task<string> Insert(MsgDM data);

        /// <summary>
        /// 删除实体
        /// </summary>
        Task<bool> Delete(string id);
    }
}
