using System.Collections.Generic;

namespace AtskungFu.WebAPI.Models
{
    public class Professor
    {
        public Professor()
        {

        }
        public Professor(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
        public IEnumerable<Modalidade> Modalidade { get; set; }
    }
}