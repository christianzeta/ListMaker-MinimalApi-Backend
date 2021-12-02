using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class ListData
{
    private readonly ISqlDataAccess _db;

    public ListData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ListModel>> GetLists() =>
            _db.LoadData<ListModel, dynamic>("dbo.spList_GetAll", new { });

    public async Task<ListModel?> GetList(int id)
    {
        var results = await _db.LoadData<ListModel, dynamic>("dbo.spLists_Get", new {Id = id});

        return results.FirstOrDefault();
    }

    public Task insertList(ListModel list) =>
        _db.SaveData("dbo.spLists_Insert", new { list.Title});

    public Task updateList(ListModel list) =>
        _db.SaveData("dbo.spLists_Update", list);

    public Task deleteList(int id) =>
        _db.SaveData("dbo.spLists_Delete", new { Id = id});
    
}
