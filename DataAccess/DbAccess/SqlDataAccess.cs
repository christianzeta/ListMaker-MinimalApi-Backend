﻿using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DataAccess.DbAccess;

public class SqlDataAccess
{
    private readonly IConfiguration _config;
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    } 

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectiondId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectiondId));

        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectiondId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectiondId));

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}
