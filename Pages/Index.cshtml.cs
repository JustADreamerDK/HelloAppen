using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloApp
{
    public class IndexModel : PageModel
    {
        public List<string> ToDoList;
        public void OnGet()
        {
            ToDoList = new List<string>();
            for(int i = 1; i <= 100; i++){
                ToDoList.Add("Opgave " + i);
            }
        }
    }
}
