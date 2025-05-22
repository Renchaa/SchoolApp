using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using rp23052NetMD4.Models;
using rp23052NetMD4.Services;
using System.Diagnostics;

namespace rp23052NetMD4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Galvenā lapa
        public IActionResult Index()
        {
            return View();
        }

        // Students Management
        public async Task<IActionResult> Students()
        {
            var students = await _context.Students.ToListAsync();
            return View(students); // Show Students
        }
        public async Task<IActionResult> EditStudent(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Ja ID nav norādīts
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound(); // Ja students ar šo ID neeksistē
            }

            return View(student); // Atver EditStudent.chtml ar konkrēto studentu
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Student edit loģika 
        public async Task<IActionResult> EditStudent(Student student)
        {
            _logger.LogInformation("EditStudent metode tika izsaukta ar ID: {Id}", student.Id);
            _logger.LogInformation("Before updating student in database.");
            _context.Update(student);
            await _context.SaveChangesAsync();
            _logger.LogInformation("After updating student in database.");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Student updated successfully.";
                    return RedirectToAction(nameof(Students));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error updating student.");
                    ModelState.AddModelError("", "An error occurred while saving data. Please try again.");
                }
            }
            else
            {
                _logger.LogWarning("ModelState is not valid: {Errors}", ModelState.Values.SelectMany(v => v.Errors));
            }
            _logger.LogInformation("Before updating student in database.");
            _context.Update(student);
            await _context.SaveChangesAsync();
            _logger.LogInformation("After updating student in database.");

            return View(student);
        }
        //Studentu dzēšana
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student deleted successfully!";
            }
            else
            {
                TempData["ErrorMessage"] = "Student not found!";
            }
            return RedirectToAction(nameof(Students)); // Pēc dzēšanas pāriet uz studentu sarakstu
        }
        //Get studentu izveide
        public IActionResult CreateStudent()
        {
            return View();
        }
        //post studentu izveide
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            _logger.LogInformation("CreateStudent method invoked.");

            try
            {
                if (ModelState.IsValid)
                {
                    _logger.LogInformation("ModelState is valid. Adding student to the database.");

                    _context.Add(student);
                    await _context.SaveChangesAsync();

                    _logger.LogInformation($"Student created successfully with ID: {student.Id}");

                    TempData["SuccessMessage"] = "Student created successfully.";
                    return RedirectToAction(nameof(Students));
                }
                else
                {
                    _logger.LogWarning("ModelState is invalid. Returning to the form.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the student.");
                TempData["ErrorMessage"] = "An error occurred while creating the student.";
            }

            _logger.LogInformation("Returning the view with the student model.");
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    _logger.LogWarning($"Validation error: {error.ErrorMessage}");
                }
            }

            return View(student);
        }



        // Assignment
        public async Task<IActionResult> Assignments()
        {
            var assignments = await _context.Assignments.Include(a => a.Course).ToListAsync();
            return View(assignments); // Show Assignments
        }
        // GET Assignment
        public async Task<IActionResult> EditAssignment(int? id)
        {
            if (id == null)
            {
                return NotFound(); //Nav ID
            }

            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
            {
                return NotFound(); // Assignment nav atrasta
            }

            ViewBag.Courses = new SelectList(_context.Courses, "Id", "Name", assignment.CourseId); // Kursu drop down lists
            return View(assignment); 
        }

        // POST Assignment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAssignment(Assignment assignment)
        {
            if (!ModelState.IsValid)
            {
                foreach (var key in ModelState.Keys)
                {
                    var errors = ModelState[key]?.Errors;
                    if (errors != null && errors.Count > 0)
                    {
                        foreach (var error in errors)
                        {
                            _logger.LogWarning($"Validation error for '{key}': {error.ErrorMessage}");
                        }
                    }
                }

                TempData["ErrorMessage"] = "Validation errors occurred. Please correct them and try again.";
                ViewBag.Courses = new SelectList(_context.Courses, "Id", "Name", assignment.CourseId);
                return View(assignment);
            }

            try
            {
                _context.Update(assignment);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Assignment updated successfully.";
                return RedirectToAction(nameof(Assignments));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating assignment.");
                TempData["ErrorMessage"] = "An error occurred while updating the assignment.";
            }

            ViewBag.Courses = new SelectList(_context.Courses, "Id", "Name", assignment.CourseId);
            return View(assignment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
            {
                TempData["ErrorMessage"] = "Assignment not found.";
                return RedirectToAction(nameof(Assignments));
            }

            try
            {
                _context.Assignments.Remove(assignment);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Assignment deleted successfully.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting assignment.");
                TempData["ErrorMessage"] = "An error occurred while deleting the assignment.";
            }

            return RedirectToAction(nameof(Assignments));
        }
        // GET: CreateAssignment
        public IActionResult CreateAssignment()
        {
            ViewBag.Courses = new SelectList(_context.Courses, "Id", "Name");
            return View();
        }

        // POST: CreateAssignment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAssignment(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(assignment);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Assignment created successfully.";
                    return RedirectToAction(nameof(Assignments));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error creating assignment.");
                    TempData["ErrorMessage"] = "An error occurred while creating the assignment.";
                }
            }

           
            ViewBag.Courses = new SelectList(_context.Courses, "Id", "Name", assignment.CourseId);
            return View(assignment);
        }
        // Submissions 
        public async Task<IActionResult> Submissions()
        {
            var submissions = await _context.Submissions.Include(s => s.Student).Include(s => s.Assignment).ToListAsync();
            return View(submissions); //Parāda submission
        }
        public async Task<IActionResult> EditSubmission(int? id)
        {
            if (id == null) return NotFound();

            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null) return NotFound();

            ViewBag.Assignments = new SelectList(_context.Assignments, "Id", "Description", submission.AssignmentId);
            ViewBag.Students = new SelectList(_context.Students, "Id", "Name", submission.StudentId);

            return View(submission);
        }

        // POST metode EditSubmission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSubmission(Submission submission)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submission);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Submission updated successfully.";
                    return RedirectToAction(nameof(Submissions));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error updating submission.");
                    TempData["ErrorMessage"] = "An error occurred while updating the submission.";
                }
            }

            ViewBag.Assignments = new SelectList(_context.Assignments, "Id", "Description", submission.AssignmentId);
            ViewBag.Students = new SelectList(_context.Students, "Id", "Name", submission.StudentId);

            return View(submission);
        }

        // GET: CreateSubmission
        public IActionResult CreateSubmission()
        {
            ViewBag.Assignments = new SelectList(_context.Assignments, "Id", "Description");
            ViewBag.Students = new SelectList(_context.Students, "Id", "Name");
            return View();
        }

        // POST: CreateSubmission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSubmission(Submission submission)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(submission);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Submission created successfully.";
                    return RedirectToAction(nameof(Submissions));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error creating submission.");
                    TempData["ErrorMessage"] = "An error occurred while creating the submission.";
                }
            }

            ViewBag.Assignments = new SelectList(_context.Assignments, "Id", "Description", submission.AssignmentId);
            ViewBag.Students = new SelectList(_context.Students, "Id", "Name", submission.StudentId);

            return View(submission);
        }

        // POST: DeleteSubmission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSubmission(int id)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission != null)
            {
                try
                {
                    _context.Submissions.Remove(submission);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Submission deleted successfully.";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error deleting submission.");
                    TempData["ErrorMessage"] = "An error occurred while deleting the submission.";
                }
            }

            return RedirectToAction(nameof(Submissions));
        }

        public async Task<IActionResult> Teachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers); // Padod Teachers listu uz Teachers.cshtml
        }

        public async Task<IActionResult> Courses()
        {
            var courses = await _context.Courses.Include(c => c.Teacher).ToListAsync();
            return View(courses); // Padod Courses listu uz Courses.cshtml
        }

        // Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
