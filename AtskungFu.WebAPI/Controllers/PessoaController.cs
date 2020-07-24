using System.Collections.Generic;
using System.Linq;
using AtskungFu.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtskungFu.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PessoaController :ControllerBase
    {
        public List<Pessoa> Pessoas = new List<Pessoa>{
            new Pessoa() {
                Id = 1 ,
                Nome = "Flávio Nogueira"                
            },
             new Pessoa() {
                Id = 2 ,
                Nome = "Bryan Nogueira"                
            },
             new Pessoa() {
                Id = 3 ,
                Nome = "Ashley Nogueira"                
            },
             new Pessoa() {
                Id = 4 ,
                Nome = "Elenice Nogueira"                
            }
        } ;
        public PessoaController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Pessoas);            
        }

         
         //api/pessoa
        [HttpPost]
        public IActionResult Post(Pessoa pessoa)
        {
            return Ok(pessoa);            
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Pessoa pessoa)
        {
            return Ok(pessoa);            
        }


       [HttpPatch("{id}")]
        public IActionResult Patch(int id,Pessoa pessoa)
        {
            return Ok(pessoa);            
        }


        [HttpDelete("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();            
        }

        //api/pessoa/by 
        //Usando Query string   [HttpGet("byId")]  //api/pessoa/byid?id=1
        //usando id como parte da rota    [HttpGet("byId/{id}")] /api/pessoa/byid/1
         [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var pessoa =Pessoas.FirstOrDefault(a => a.Id == id) ;

            if (pessoa == null) 
               return BadRequest("Pessoa não encontrada");

            return Ok(pessoa);
            
        }

         [HttpGet("ByNome")]
        public IActionResult GetByNome(string nome, string sobrenome)
        {
            var pessoa =Pessoas.FirstOrDefault(a => a.Nome.Contains(nome) &&
                                                    a.Sobrenome.Contains(sobrenome)) ;

            if (pessoa == null) 
               return BadRequest("Pessoa não encontrada");

            return Ok(pessoa);
            
        }
    }
}