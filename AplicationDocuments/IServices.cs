using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AplicationDocuments.Data
{
    public interface IServices
    {
        Task<List<DocumentDto>> GetAllDocuments(int id);

        Task<int> InsertAllDocuments(List<DocumentModel> resquestList);
    }
}
