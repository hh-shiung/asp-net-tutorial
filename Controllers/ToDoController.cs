using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ToDoController : ControllerBase
  {
    private readonly ToDoContext _context;

    public ToDoController(ToDoContext context)
    {
      _context = context;

      if (_context.ToDoItems.Count() == 0)
      {
        // Create new ToDoItem if collection is empty
        _context.ToDoItems.Add(new ToDoItem { Name = "Item1" });
        _context.SaveChanges();
      }
    }
  }
}
