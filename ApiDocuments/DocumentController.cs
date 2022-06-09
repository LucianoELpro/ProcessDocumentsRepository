using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicationDocuments.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDocuments
{
    public class DocumentController : Controller
    {
        private readonly IServices _services;
        public DocumentController(IServices services)
        {
            _services = services;
        }
        [HttpGet("{id}")]
        // GET: /<controller>/
        public async Task<ActionResult<List<DocumentDto>>> GetAll(int id)
        {
            return  await _services.GetAllDocuments(id);

                   
        }
    }
}
