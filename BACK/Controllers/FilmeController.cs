using System;
using System.Collections.Generic;
using System.Linq;
using BACK.Data;
using BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACK.Controllers
{
    [ApiController]
    [Route("api/filme")]
    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;
        public FilmeController(DataContext context)
        {
            _context = context;
        }

        //POST: /api/Filme/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return Created("", filme);
        }

        //GET: /api/Filme/list
        [Route("list")]
        [HttpGet]
        public IActionResult List() => Ok(_context.Filmes.ToList());

        //GET: api/Filme/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            //Buscar um objeto pela chave primária
            Filme filme = _context.Filmes.Find(id);
            if (filme == null)
            {
                return NotFound();
            }
            return Ok(filme);
        }

        //GET: api/Filme/delete/Matrix
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete(string name)
        {
            //Where -> Expressão lambda
            //Buscar um objeto pelo nome
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Nome == name);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            return Ok(_context.Filmes.ToList());
        }

        //PUT: /api/Filme/create
        [Route("update")]
        [HttpPut]
        public IActionResult Update([FromBody] Filme filme)
        {
            _context.Filmes.Update(filme);
            _context.SaveChanges();
            return Ok(filme);
        }
    }
}