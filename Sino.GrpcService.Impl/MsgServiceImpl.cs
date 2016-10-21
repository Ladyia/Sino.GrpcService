using Grpc.Core;
using Sino.GrpcService.Model;
using Sino.GrpcService.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Sino.GrpcService
{
    public class MsgServiceImpl : MsgService.MsgServiceBase
    {
        private IMsgRepository _msgRepository;

        public MsgServiceImpl(IMsgRepository msgRepository)
        {
            _msgRepository = msgRepository;
        }

        public override async Task<GetMsgListReply> GetList(GetMsgListRequest request, ServerCallContext context)
        {
            var result = new GetMsgListReply();
            var list = await _msgRepository.GetList(request.UserId, request.Title, request.StartTime, request.EndTime);
            result.IsSuccess = true;
            result.Items.AddRange(list.Select(x => new GetMsgListReply.Types.MsgItem
            {
                UserId = x.UserId,
                Title = x.Title,
                Time = x.Time,
                Content = x.Content
            }).ToList());
            return result;
        }

        public override async Task<EditMsgReply> Edit(EditMsgRequest request, ServerCallContext context)
        {
            var result = new EditMsgReply();
            result.IsSuccess = await _msgRepository.Update(new MsgDM
            {
                Id = new MongoDB.Bson.ObjectId(request.Id),
                Title = request.Title,
                Content = request.Content
            });

            return result;
        }

        public override async Task<GetMsgOneReply> GetOne(GetMsgOneRequest request, ServerCallContext context)
        {
            var msg = await _msgRepository.Get(request.Id);

            return new GetMsgOneReply
            {
                IsSuccess = true,
                Id = msg.Id.ToString(),
                UserId = msg.UserId,
                Title = msg.Title,
                Content = msg.Content,
                Time = msg.Time
            };
        }

        public override async Task<RemoveMsgReply> Remove(RemoveMsgRequest request, ServerCallContext context)
        {
            var result = new RemoveMsgReply();
            result.IsSuccess = await _msgRepository.Delete(request.Id);

            return result;
        }
    }
}
