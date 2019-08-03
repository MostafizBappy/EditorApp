using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Helpers;
using EditorApp.API.Data;
using EditorApp.API.Dtos;
using EditorApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EditorApp.API.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    public class StoryController : Controller
    {
        // private readonly ReporterContext _context;
        private readonly IEditorRepository _repo;
        private readonly IMapper _mapper;
        private readonly ReporterContext _context;
        public StoryController(IEditorRepository repo, IMapper mapper, ReporterContext context)
        {
            _context = context;
            _mapper = mapper;
            _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetStories(StoryParams param)
        {
            var stories = await _repo.GetStories(param);
            var storyListToReturn = _mapper.Map<IEnumerable<StoryForReturnDto>>(stories);
            Response.AddPagination(stories.CurrentPage, stories.PageSize, stories.TotalCount, stories.TotalPages);
            return Ok(storyListToReturn);
        }
        //s
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStory(int id)
        {
            var story = await _repo.GetStory(id);
            var storyForReturn = _mapper.Map<StoryForReturnDto>(story);
            return Ok(storyForReturn);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await _repo.GetAuthorList();
            var authorToReturn = _mapper.Map<IEnumerable<AuthorListDto>>(authors);
            return Ok(authorToReturn);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetCenterNames()
        {
            var centers = await _repo.GetCenterList();
            return Ok(centers);
        }

        [HttpPost]
        public async Task<IActionResult> SaveStory([FromBody]StoryForReturnDto storyToSave)
        {
            Story story = _mapper.Map<Story>(storyToSave);
            bool headingExists = _repo.IsHeadingExists(storyToSave.StoryHeading);
            if (!headingExists)
            {
                story.StoryDate = DateTime.Now;
                story.EntryDate = DateTime.Now;
                story.UpdateDate = DateTime.Now;
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                string userCode = _context.DwEmployee.Where(e => e.Ldapint == userId).FirstOrDefault().Employeecode;
                story.UserCode = userCode;
                story.Status = 0;
                story.ApprovalCheck = 0;
                story.PageCheck = 0;
                int wordCount = 0, index = 0;
                while (index < story.StoryBody.Length)
                {
                    while (index < story.StoryBody.Length && Char.IsWhiteSpace(story.StoryBody[index]) == false)
                        index++;
                    wordCount++;
                    while (index < story.StoryBody.Length && Char.IsWhiteSpace(story.StoryBody[index]) == true)
                        index++;
                }
                story.StoryWord = wordCount;

                _repo.Add<Story>(story);
            }
            else
                return BadRequest("Heading already exists");

            if (await _repo.SaveAll())
                return Ok();

            return BadRequest("Failed to Save");
        }
    }
}