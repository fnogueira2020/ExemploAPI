using System.Collections.Generic;

namespace AtskungFu.WebAPI.Models
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(int id, int pessoaID)
        {
            this.Id = id;
            this.PessoaID = pessoaID;
  

        }
        public int Id { get; set; }
        public int PessoaID { get; set; }
        public Pessoa Pessoa { get; set; }
        public IEnumerable<AlunoModalidade> AlunoModalidade {get; set; }

    }
}