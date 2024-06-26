﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartNotes.Application.Dto;
using SmartNotes.Domain.NoteFeature.Entities;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public NoteController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var items = _noteService.GetAll();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _noteService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NoteDto note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var model = _mapper.Map<Note>(note);

            var item = _noteService.Add(model);
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var existingItem = _noteService.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _noteService.Remove(id);

            return NoContent();
        }
    }
}
