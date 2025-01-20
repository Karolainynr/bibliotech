using Bibliotech.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/livros")]
public class LivrosController : ControllerBase
{
    [HttpGet("buscar")]

    public IActionResult Buscar(string titulo)
    {
        //TODO: acessar o banco de dados e pesquisar.

        var livros = ObterLivrosMockados();

        return Ok(livros);
    }

    private List<Livro> ObterLivrosMockados()
    {
        // Dados mockados para Assuntos
        var assuntos = new List<Assunto>
    {
        new Assunto { Id = 1, Descricao = "Ficção Científica", Status = "Ativo" },
        new Assunto { Id = 2, Descricao = "Fantasia", Status = "Ativo" },
        new Assunto { Id = 3, Descricao = "Romance", Status = "Ativo" },
        new Assunto { Id = 4, Descricao = "Não-ficção", Status = "Ativo" },
        new Assunto { Id = 5, Descricao = "Biografias", Status = "Ativo" }
    };

        // Dados mockados para Autores
        var autores = new List<Autor>
    {
        new Autor { Id = 1, Nome = "Colleen Hoover", Email = "colleen@hoover.com", DataNascimento = new DateTime(1979, 12, 11), Status = "Ativo" },
        new Autor { Id = 2, Nome = "Delia Owens", Email = "delia@owens.com", DataNascimento = new DateTime(1949, 4, 4), Status = "Ativo" },
        new Autor { Id = 3, Nome = "Michelle Obama", Email = "michelle@obama.com", DataNascimento = new DateTime(1964, 1, 17), Status = "Ativo" },
        new Autor { Id = 4, Nome = "George R. R. Martin", Email = "george@martin.com", DataNascimento = new DateTime(1948, 9, 20), Status = "Ativo" },
        new Autor { Id = 5, Nome = "J.K. Rowling", Email = "jk@rowling.com", DataNascimento = new DateTime(1965, 7, 31), Status = "Ativo" }
    };

        // Lista com livros best-sellers dos últimos 10 anos
        var livros = new List<Livro>
    {
        new Livro { Id = 1, Titulo = "Verity", ISBN = "978-1542019663", Editora = "Atria Books", AnoPublicacao = 2018, AssuntoId = 1, AutorId = 1, Assunto = assuntos[0], Autor = autores[0] },
        new Livro { Id = 2, Titulo = "Where the Crawdads Sing", ISBN = "978-0735219090", Editora = "G.P. Putnam's Sons", AnoPublicacao = 2018, AssuntoId = 2, AutorId = 2, Assunto = assuntos[1], Autor = autores[1] },
        new Livro { Id = 3, Titulo = "Becoming", ISBN = "978-1524763138", Editora = "Crown Publishing Group", AnoPublicacao = 2018, AssuntoId = 4, AutorId = 3, Assunto = assuntos[3], Autor = autores[2] },
        new Livro { Id = 4, Titulo = "A Song of Ice and Fire", ISBN = "978-0553103540", Editora = "Bantam Spectra", AnoPublicacao = 1996, AssuntoId = 2, AutorId = 4, Assunto = assuntos[1], Autor = autores[3] },
        new Livro { Id = 5, Titulo = "The Harry Potter Series", ISBN = "978-0545582889", Editora = "Scholastic Inc.", AnoPublicacao = 1997, AssuntoId = 2, AutorId = 5, Assunto = assuntos[1], Autor = autores[4] },
        new Livro { Id = 6, Titulo = "It Ends with Us", ISBN = "978-1501110368", Editora = "Atria Books", AnoPublicacao = 2016, AssuntoId = 3, AutorId = 1, Assunto = assuntos[2], Autor = autores[0] },
        new Livro { Id = 7, Titulo = "The Silent Patient", ISBN = "978-1250301697", Editora = "Celadon Books", AnoPublicacao = 2019, AssuntoId = 4, AutorId = 2, Assunto = assuntos[3], Autor = autores[1] },
        new Livro { Id = 8, Titulo = "Educated", ISBN = "978-0399590504", Editora = "Random House", AnoPublicacao = 2018, AssuntoId = 4, AutorId = 3, Assunto = assuntos[3], Autor = autores[2] },
        new Livro { Id = 9, Titulo = "The Night Circus", ISBN = "978-0307744432", Editora = "Doubleday", AnoPublicacao = 2011, AssuntoId = 2, AutorId = 1, Assunto = assuntos[1], Autor = autores[0] },
        new Livro { Id = 10, Titulo = "The Midnight Library", ISBN = "978-0593135347", Editora = "Riverhead Books", AnoPublicacao = 2020, AssuntoId = 4, AutorId = 2, Assunto = assuntos[3], Autor = autores[1] },
        new Livro { Id = 11, Titulo = "The Giver of Stars", ISBN = "978-1984818499", Editora = "Pamela Dorman Books", AnoPublicacao = 2019, AssuntoId = 5, AutorId = 2, Assunto = assuntos[4], Autor = autores[1] },
        new Livro { Id = 12, Titulo = "The Seven Husbands of Evelyn Hugo", ISBN = "978-1501161933", Editora = "Atria Books", AnoPublicacao = 2017, AssuntoId = 2, AutorId = 1, Assunto = assuntos[1], Autor = autores[0] },
        new Livro { Id = 13, Titulo = "The Tattooist of Auschwitz", ISBN = "978-0062797155", Editora = "HarperCollins", AnoPublicacao = 2018, AssuntoId = 5, AutorId = 2, Assunto = assuntos[4], Autor = autores[1] },
        new Livro { Id = 14, Titulo = "The Woman in the Window", ISBN = "978-0062678416", Editora = "William Morrow", AnoPublicacao = 2018, AssuntoId = 4, AutorId = 2, Assunto = assuntos[3], Autor = autores[1] },
        new Livro { Id = 15, Titulo = "Big Little Lies", ISBN = "978-0399167065", Editora = "Berkley", AnoPublicacao = 2014, AssuntoId = 3, AutorId = 2, Assunto = assuntos[2], Autor = autores[1] },
        new Livro { Id = 16, Titulo = "Before We Were Strangers", ISBN = "978-1501100178", Editora = "Atria Books", AnoPublicacao = 2015, AssuntoId = 3, AutorId = 1, Assunto = assuntos[2], Autor = autores[0] },
        new Livro { Id = 17, Titulo = "Anxious People", ISBN = "978-1982137567", Editora = "Atria Books", AnoPublicacao = 2019, AssuntoId = 4, AutorId = 3, Assunto = assuntos[3], Autor = autores[2] },
        new Livro { Id = 18, Titulo = "The Couple Next Door", ISBN = "978-1101974151", Editora = "Ballantine Books", AnoPublicacao = 2016, AssuntoId = 4, AutorId = 2, Assunto = assuntos[3], Autor = autores[1] },
        new Livro { Id = 19, Titulo = "Circe", ISBN = "978-0316556347", Editora = "Little, Brown and Company", AnoPublicacao = 2018, AssuntoId = 2, AutorId = 2, Assunto = assuntos[1], Autor = autores[1] },
        new Livro { Id = 20, Titulo = "The Invisible Life of Addie LaRue", ISBN = "978-0765387561", Editora = "Viking", AnoPublicacao = 2020, AssuntoId = 2, AutorId = 1, Assunto = assuntos[1], Autor = autores[0] }
    };

        return livros;
    }

}


//niveis de acesso
//protected = amigo do peito
//public = todo mundo sabe de tudo
//private = nunguem tem acesso, somente eu
//internal = só a galera do grupo

//namespace