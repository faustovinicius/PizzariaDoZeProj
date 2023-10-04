using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PizzariaDoZe.DAO;
public class Ingrediente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Ingrediente(int id = 0, string nome = "")
    {
        Id = id;
        Nome = nome;
    }
}
