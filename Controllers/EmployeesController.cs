using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        private static List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 75000 },
            new Employee { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 60000 }
        };

        public IActionResult Index() => View(_employees);

        public IActionResult Details(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = _employees.Count > 0 ? _employees.Max(e => e.Id) + 1 : 1;
                _employees.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Employee updated)
        {
            if (id != updated.Id) return NotFound();
            if (ModelState.IsValid)
            {
                var emp = _employees.FirstOrDefault(e => e.Id == id);
                if (emp == null) return NotFound();
                emp.Name = updated.Name;
                emp.Position = updated.Position;
                emp.Salary = updated.Salary;
                return RedirectToAction(nameof(Index));
            }
            return View(updated);
        }

        public IActionResult Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp != null) _employees.Remove(emp);
            return RedirectToAction(nameof(Index));
        }
    }
}
