using System.Collections.Generic;

namespace AtskungFu.WebAPI.Models
{
    public class Modalidade
    {
        public Modalidade()
        {
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Descricao { get; set; }

        public IEnumerable<AlunoModalidade> AlunoModalidade {get; set; }
    }
}