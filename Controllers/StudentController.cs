using Microsoft.AspNetCore.Mvc;
using WebAppMVP.Data;
using WebAppMVP.Models;

namespace WebAppMVP.Controllers
{

	//Class
	public class StudentController : Controller
	{
		//Field
		private readonly ApplicationDBContext _db;
		//Dependency Injection
		public StudentController(ApplicationDBContext db)
		{
			_db = db;
		}
		//Method
		public IActionResult Index()
		{
			IEnumerable<Student> allStudent = _db.Students;
			return View(allStudent);
		}
		//Method: Get
		public IActionResult Create()
		{
			return View();
		}
		//Method-Post
		//Attribute
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Student obj)
		{
			//Link to Data Annotation in StudentModel
			if (ModelState.IsValid)
			{
				_db.Students.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}
		//Method
		public IActionResult Edit(int? id)
		{
			if (id==null||id==0) { return NotFound(); }
			var obj = _db.Students.Find(id);
			if (obj==null) { return NotFound(); }
			return View(obj);
		}
		//Method-Post
		//Attribute
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Student obj)
		{
			//Link to Data Annotation in StudentModel
			if (ModelState.IsValid)
			{
				_db.Students.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}
		//Method
		public IActionResult Delete(int? id)
		{
			if (id==null||id==0) { return NotFound(); }
			var obj = _db.Students.Find(id);
			if (obj==null) { return NotFound(); }
			_db.Students.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");

		}
	}
}
