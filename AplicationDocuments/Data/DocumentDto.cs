using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationDocuments.Data
{
    public class DocumentDto
    {

        
        public int IdDocContable { get; set; }
      
        public string Descripcion { get; set; }
        public int IdDocContableCliente { get; set; }
        public string FileData { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string ComentarioAprobador { get; set; }
        public string ComenAnalista { get; set; }

    }
}
