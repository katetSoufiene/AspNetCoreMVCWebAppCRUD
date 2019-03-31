using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Interfaces;
using ApplicationCore.Entities;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository context)
        {
            _repository = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _repository.ListAllAsync());
        }

        // GET: Employee/Create
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Employee());
            else

                return View( await _repository.GetByIdAsync(id));
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,FirstName,LastName,Email,Departement")] Employee employee)
        {


            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    await _repository.AddAsync(employee);
                }
                else
                {
                    await _repository.UpdateAsync(employee);
                }

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var employee = await _repository.GetByIdAsync((int)id);
                if (employee == null)
                {
                    return NotFound();
                }
                await _repository.DeleteAsync(employee);
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
