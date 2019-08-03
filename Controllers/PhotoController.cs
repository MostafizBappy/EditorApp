using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace EditorApp.API.Controllers {
    public class PhotoController : Controller {
        private readonly IEditorRepository _repo;
        public PhotoController (IEditorRepository repo) {
            _repo = repo;

        }
    }
}