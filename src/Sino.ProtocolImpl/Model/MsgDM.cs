using MongoDB.Bson;

namespace Sino.GrpcService.Model
{
    /// <summary>
    /// 消息体
    /// </summary>
    public sealed class MsgDM
    {
        /// <summary>
        /// 编号
        /// </summary>
        public ObjectId Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public long Time { get; set; }
    }
}