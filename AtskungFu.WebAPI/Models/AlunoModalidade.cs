namespace AtskungFu.WebAPI.Models
{
    public class AlunoModalidade
    {
        public AlunoModalidade()
        {}

           
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}