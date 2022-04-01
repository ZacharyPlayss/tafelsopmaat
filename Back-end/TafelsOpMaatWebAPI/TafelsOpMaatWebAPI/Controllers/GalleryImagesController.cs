using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TafelsOpMaatWebAPI.Models;

namespace TafelsOpMaatWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryImagesController : ControllerBase
    {
        private readonly TafelsOpMaatContext _context;

        public GalleryImagesController(TafelsOpMaatContext context)
        {
            _context = context;
        }

        // GET: api/GalleryImages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GalleryImage>>> GetGalleryImages()
        {
            return await _context.GalleryImages.ToListAsync();
        }

        // GET: api/GalleryImages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GalleryImage>> GetGalleryImage(long id)
        {
            var galleryImage = await _context.GalleryImages.FindAsync(id);

            if (galleryImage == null)
            {
                return NotFound();
            }

            return galleryImage;
        }

        // PUT: api/GalleryImages/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGalleryImage(long id, GalleryImage galleryImage)
        {
            if (id != galleryImage.Id)
            {
                return BadRequest();
            }

            _context.Entry(galleryImage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GalleryImageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GalleryImages
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GalleryImage>> PostGalleryImage(GalleryImage galleryImage)
        {
            _context.GalleryImages.Add(galleryImage);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGalleryImage), new { id = galleryImage.Id }, galleryImage);
        }

        // DELETE: api/GalleryImages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GalleryImage>> DeleteGalleryImage(long id)
        {
            var galleryImage = await _context.GalleryImages.FindAsync(id);
            if (galleryImage == null)
            {
                return NotFound();
            }

            _context.GalleryImages.Remove(galleryImage);
            await _context.SaveChangesAsync();

            return galleryImage;
        }

        private bool GalleryImageExists(long id)
        {
            return _context.GalleryImages.Any(e => e.Id == id);
        }
    }
}
