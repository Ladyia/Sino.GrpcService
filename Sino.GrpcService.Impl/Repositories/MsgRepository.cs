using MongoDB.Bson;
using MongoDB.Driver;
using Sino.GrpcService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sino.GrpcService.Repositories
{
    public class MsgRepository : IMsgRepository
    {
        private IDataContext _dataContext;
        private IMongoCollection<MsgDM> _collection;

        public MsgRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
            _collection = _dataContext.Database.GetCollection<MsgDM>("msg");
        }

        public async Task<bool> Delete(string id)
        {
            var filter = Builders<MsgDM>.Filter.Eq(x => x.Id, new ObjectId(id));
            var result = await _collection.DeleteOneAsync(filter);
            return result.DeletedCount == 1;
        }

        public Task<MsgDM> Get(string id)
        {
            var objectId = new ObjectId(id);
            var result = (from item in _collection.AsQueryable()
                          where item.Id == objectId
                          select item).FirstOrDefault();
            return Task.FromResult(result);
        }

        public Task<List<MsgDM>> GetList(long userId, string title, long startTime, long endTime)
        {
            IQueryable<MsgDM> filter = _collection.AsQueryable();
            if (userId != 0)
                filter = filter.Where(x => x.UserId == userId);
            if (!string.IsNullOrEmpty(title))
                filter = filter.Where(x => x.Title.Contains(title));
            if (startTime != 0)
                filter = filter.Where(x => x.Time > startTime);
            if (endTime != 0)
                filter = filter.Where(x => x.Time < startTime);

            return Task.FromResult(filter.ToList());
        }

        public async Task<string> Insert(MsgDM data)
        {
            await _collection.InsertOneAsync(data);
            return data.Id.ToString();
        }

        public async Task<bool> Update(MsgDM data)
        {
            var filter = Builders<MsgDM>.Filter.Eq(x => x.Id, data.Id);
            var update = Builders<MsgDM>.Update.Set(x => x.Title, data.Title).Set(x => x.Content, data.Content);

            var result = await _collection.UpdateOneAsync(Builders<MsgDM>.Filter.Eq(x => x.Id, data.Id), update);

            return result.ModifiedCount == 1;
        }
    }
}
