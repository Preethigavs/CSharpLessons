using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindApplication.Models
{
    public class CustomerIdsViewModel
    {
  
            public int Id { get; set; }
            public readonly List<SelectListItem> CustomerIdsSelectedList;


            public CustomerIdsViewModel(List<string> custIds)
            {
                {
                CustomerIdsSelectedList = new List<SelectListItem>();
                    foreach (var no in custIds)
                    {
                    CustomerIdsSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
                    }
                }
            }

        
    }
}
