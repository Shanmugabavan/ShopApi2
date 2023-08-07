using ShopAPI.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Application;

public interface IItemRepository
{
    Task<ActionResult<IEnumerable<Item>>> GetItems();
    Task<ActionResult<Item>> GetItemById(int id);
    Task<IActionResult> PutItemById(int id, Item item);
    Task<ActionResult<Item>> PostItemByID(Item item);
    Task<IActionResult> DeleteItemById(int id);

}
