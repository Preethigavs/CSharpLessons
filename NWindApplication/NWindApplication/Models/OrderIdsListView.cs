using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindApplication.Models
{
    public class OrderIdsListView
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdsSelectedList;

      
        public OrderIdsListView(List<int> orderIds)
        {
            {
                OrderIdsSelectedList = new List<SelectListItem>();
                foreach (var no in orderIds)
                {
                    OrderIdsSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
                }
            }
        }
        
    }
}
