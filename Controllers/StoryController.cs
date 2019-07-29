using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Helpers;
using EditorApp.API.Data;
using EditorApp.API.Dtos;
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
        public StoryController(IEditorRepository repo, IMapper mapper)
        {
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
    }
}