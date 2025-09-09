using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Model
{
    public class RM99134_Fornecedor
    {
        public int idFornecedor { get; set; }
        public string nrCep { get; set; }
        public string dsEndereco { get; set; }  
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
