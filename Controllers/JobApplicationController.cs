using JobTracker.Data;
using JobTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace JobTracker.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET all job applications, anyone can view jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobApplication>>> GetJobApplications()
        {
            return await _context.JobApplications.ToListAsync();
        }

        // GET a single job application by ID, anyone can view a job by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<JobApplication>> GetJobApplication(int id)
        {
            var jobApplication = await _context.JobApplications.FindAsync(id);
            if (jobApplication == null)
            {
                return NotFound();
            }
            return jobApplication;
        }

        // POST a new job application
        // Only Admin can create job applications
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<JobApplication>> PostJobApplication(JobApplication jobApplication)
        {
            _context.JobApplications.Add(jobApplication);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetJobApplication), new { id = jobApplication.Id }, jobApplication);
        }

        // PUT Update a job application
        // Only Admin can update job applications
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobApplication(int id, JobApplication jobApplication)
        {
            if (id != jobApplication.Id)
            {
                return BadRequest();
            }
            _context.Entry(jobApplication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.JobApplications.Any(e => e.Id == id))
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

        // DELETE : Remove a job application
        // Only Admin can delete job applications
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobApplication(int id)
        {
            var jobApplication = await _context.JobApplications.FindAsync(id);
            if (jobApplication == null)
            {
                return NotFound();
            }
            _context.JobApplications.Remove(jobApplication);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
