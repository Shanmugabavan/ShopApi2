using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Application;
using ShopAPI.DatabaseContext;
using ShopAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Infrastructure;

public class ItemRepository
{
    protected readonly ShopAPIContext _context;

    public ItemRepository (ShopAPIContext context)
    {
        this._context = context;
    }

    public async Task<List<Item>> GetItems()
    {
        var items = await _context.Item.ToListAsync();
        return items;
    }

    public async Task<Item> GetItemById(int id)
    {
        var item = await _context.Item.FindAsync(id);

        return item;
    }

    // PUT: api/Items/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    public async Task<int> PutItemById(int id, Item item)
    {

        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return 0;
    }

    // POST: api/Items
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Item>> PostItemById(Item item)
    {
        if (_context.Item == null)
        {
            return Problem("Entity set 'ShopAPIContext.Item'  is null.");
        }
        _context.Item.Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetItem", new { id = item.Id }, item);
    }

    // DELETE: api/Items/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItemById(int id)
    {
        if (_context.Item == null)
        {
            return NotFound();
        }
        var item = await _context.Item.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        _context.Item.Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ItemExists(int id)
    {
        return (_context.Item?.Any(e => e.Id == id)).GetValueOrDefault();
    }

}
