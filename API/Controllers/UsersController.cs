using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("Api/[Controller]")] //  api/users

public class UsersController : ControllerBase  // added the derived ":ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        //this.context = context; 
        // a lot of developers dont like the "this" so we wont use this.
        _context = context;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }
    
    [HttpGet("{id}")] // api/users/2  // this is to get an exact users from the table.
    public async Task<ActionResult<AppUser>> GetUser(int id)  // getter from the db
    {

        return await _context.Users.FindAsync(id);
    }


}

