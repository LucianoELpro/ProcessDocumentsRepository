using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AplicationDocuments.Data
{
    public class Services : IServices
    {

        private readonly IConfiguration _config;

        public Services(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection { get { return new SqlConnection(_config.GetConnectionString("DbConnection")); } }

        public async Task<List<DocumentDto>> GetAllDocuments(int id)
        {

            try
            {
                using (var connection = Connection)
                {
                    connection.Open();
                    var list = await connection.QueryAsync<DocumentDto>("SpListarDocumentos",new { IdCliente = id}, commandType: CommandType.StoredProcedure);
                    List<DocumentDto> newList = new List<DocumentDto>();
                    newList = list.AsList();

                    connection.Close();
                    return newList;
                }
            }
            catch (Exception e )
            {

                throw;
            }
          
        }

        public async Task<int> InsertAllDocuments(List<DocumentModel> resquestList)
        {
            try
            {
                using (var connection = Connection)
                {
                   
                    var table = ConverList.ToDataTable<DocumentModel>(resquestList, "DtoDocuments");

                    connection.Open();
                    return await connection.ExecuteAsync("SpProcessDocuments",
                    new { Inserts = table }, commandType: CommandType.StoredProcedure);
                    
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
