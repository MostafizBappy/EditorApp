using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using EditorApp.API.Dtos;
using EditorApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EditorApp.API.Controllers {
    [Authorize]
    [Route ("api/photo")]
    public class PhotoController : Controller {
        private readonly IEditorRepository _repo;
        private readonly IMapper _mapper;
        public PhotoController (IEditorRepository repo, IMapper mapper) {
            _mapper = mapper;
            _repo = repo;

        }

        [HttpPost("{userId}")]
        public async Task<IActionResult> PhotoUpload (PhotoDto photoForUpload) {
            photoForUpload.UserCode = _repo.GetUserCode (photoForUpload.UserId);
            photoForUpload.UsedStatus = 0;
            string districtName = _repo.GetDistrictName (photoForUpload.UserCode);

            var path = "\\\\nwweb01\\dphoto\\";
            var file = photoForUpload.File;
            if (file.Length > 0) {
                photoForUpload.PhotoName = districtName + "_" + photoForUpload.UserCode +
                    "_" + DateTime.Now.ToString ("yyyy") + DateTime.Now.ToString ("MM") +
                    DateTime.Now.ToString ("dd") + "_" +
                    file.FileName.Replace ("+", "_").Replace ("jpeg", "jpg").Replace ("png", "jpg").Replace ("?", "-");

                var filePath = Path.Combine (path, photoForUpload.PhotoName);
                using (var fileStream = new FileStream (filePath, FileMode.Create)) {
                    await file.CopyToAsync (fileStream);
                }

                using (var image = Image.FromStream (file.OpenReadStream ())) {
                    photoForUpload.PhotoSize = image.Width + "x" + image.Height;
                }

            }
            PhotoSummary photo = _mapper.Map<PhotoSummary>(photoForUpload);
            _repo.Add(photo);

            if(await _repo.SaveAll())
                return NoContent();

            return BadRequest("Failed to Upload Photo.");
        }
    }
}