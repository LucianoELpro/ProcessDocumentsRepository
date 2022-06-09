using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationDocuments.Data
{
    public class DocumentModel
    {
        public int IdDoContableCliente { get; set; }
        public int IdDocContable { get; set; }
        public int IdCliente { get; set; }
        public string FileData { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string ComenAnalista { get; set; }
        public string ComentarioAprobador { get; set; }
        public bool FlagEliminacion { get; set; }


    }
}
