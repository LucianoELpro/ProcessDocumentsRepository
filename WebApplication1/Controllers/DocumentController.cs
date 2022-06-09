using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicationDocuments.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IServices _services;
        public DocumentController(IServices services)
        {
            _services = services;
        }
        [HttpGet("{id}")]
        // GET: /<controller>
        public async Task<ActionResult<List<DocumentDto>>> GetAll(int id)
        {
            return await _services.GetAllDocuments(id);


        }
        [HttpPost]
        public async Task<int> InsertAll([FromBody]List<DocumentModel> requestList)
        {
            return await _services.InsertAllDocuments(requestList);


        }
    }
}