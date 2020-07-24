using System;

namespace AtskungFu.WebAPI.Models
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(int id, string nome, string sobrenome, string cPF, string rG, string endereco, string numero, string complemento, string cep, string bairro, string cidade, string estado, string email, string telefone, string celular, string pontoReferencia, string observacoes, string urlFoto, string sexo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cPF;
            this.RG = rG;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Cep = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Email = email;
            this.Telefone = telefone;
            this.Celular = celular;
            this.PontoReferencia = pontoReferencia;
            this.Observacoes = observacoes;
            this.UrlFoto = urlFoto;
            this.Sexo = sexo;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto
        {
            get
            {
                return Nome + "  " + Sobrenome;
            }
        }
        public string CPF { get; set; }
        public string RG { get; set; }
        // [DataType(DataType.Date)]
        //  [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Data_Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string PontoReferencia { get; set; }
        public string Observacoes { get; set; }
        public string UrlFoto { get; set; }
        public string Sexo { get; set; }
        public Boolean? Situacao { get; set; }

    }
}