using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

//ASPNET CORE > FRAMEWORK DA LINGUAGEM C# PARA ESCREVER APLICAÇÕES WEB MVC E WEB API

[ApiController]
[Route("[controller]")]
public class AutoresController : ControllerBase
{
    private List<Autor> autores;

    //construtor da classe
    public AutoresController()
    {
        autores = GerarAutoresMockados();
    }

    [HttpGet("api/autores")] //NIVEL DE ACESSO   RETORNO        NOME DO METODO (PARAMETROS)
    public IActionResult Buscar(string nomeAutor)
    {
        //TODO: acessar o banco de dados e pesquisar pelo autor

        //var autores = GerarAutoresMockados();                           //retornar a consulta


        var result = autores.Where(a => a.Nome.Contains(nomeAutor, StringComparison.OrdinalIgnoreCase)).ToList();

        return Ok(result);
    }

    private List<Autor> GerarAutoresMockados()
    {
        return new List<Autor>
        {
            new Autor { Nome = "Jorge Amado", Email = "jorge@example.com", DataNascimento = new DateTime(1912, 8, 10), Status = "Ativo" },
            new Autor { Nome = "Clarice Lispector", Email = "clarice@example.com", DataNascimento = new DateTime(1920, 12, 10), Status = "Ativo" },
            new Autor { Nome = "Paulo Coelho", Email = "paulo@example.com", DataNascimento = new DateTime(1947, 8, 24), Status = "Ativo" },
            new Autor { Nome = "Gabriel Garcia Marquez", Email = "gabriel@example.com", DataNascimento = new DateTime(1927, 3, 6), Status = "Ativo" },
            new Autor { Nome = "Haruki Murakami", Email = "haruki@example.com", DataNascimento = new DateTime(1949, 1, 12), Status = "Ativo" },
            new Autor { Nome = "J.K. Rowling", Email = "jk@example.com", DataNascimento = new DateTime(1965, 7, 31), Status = "Ativo" },
            new Autor { Nome = "George Orwell", Email = "george@example.com", DataNascimento = new DateTime(1903, 6, 25), Status = "Ativo" },
            new Autor { Nome = "Toni Morrison", Email = "toni@example.com", DataNascimento = new DateTime(1931, 2, 18), Status = "Ativo" },
            new Autor { Nome = "Gabriel Garcia Marquez", Email = "gabriel@example.com", DataNascimento = new DateTime(1927, 3, 6), Status = "Ativo" },
            new Autor { Nome = "Margaret Atwood", Email = "margaret@example.com", DataNascimento = new DateTime(1939, 11, 18), Status = "Ativo" },
            new Autor { Nome = "Umberto Eco", Email = "umberto@example.com", DataNascimento = new DateTime(1932, 1, 5), Status = "Ativo" },
            new Autor { Nome = "Isabel Allende", Email = "isabel@example.com", DataNascimento = new DateTime(1942, 8, 2), Status = "Ativo" },
            new Autor { Nome = "José Saramago", Email = "jose_saramago@example.com", DataNascimento = new DateTime(1922, 11, 16), Status = "Ativo" },
            new Autor { Nome = "Mario Vargas Llosa", Email = "mario@example.com", DataNascimento = new DateTime(1936, 3, 28) }
        };

    }

    public class Autor
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Status { get; set; }
    }
}

//niveis de acesso
//protected = amigo do peito
//public = todo mundo sabe de tudo
//private = nunguem tem acesso, somente eu
//internal = só a galera do grupo