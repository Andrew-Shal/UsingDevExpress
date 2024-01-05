using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UsingDevExpress.Pages
{
    public class MyModel {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<MyModel> MyModelList { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            MyModelList = new List<MyModel>
            {
                new MyModel
                {
                    Name = "California",
                    Population=38802500,
                    Capital="Sacramento",
                    Area=423967
                },
                new MyModel
                {
                    Name = "Texas",
                    Population=26956958,
                    Capital="Austin",
                    Area=695662
                }, new MyModel
                {
                    Name = "Florida",
                    Population=19893297,
                    Capital="Tallahassee",
                    Area=170312
                }, new MyModel
                {
                    Name = "New York",
                    Population=19746227,
                    Capital="Albany",
                    Area=141297
                }, new MyModel
                {
                    Name = "Illinois",
                    Population=12880580,
                    Capital="Springfield",
                    Area=149995
                }
            };
        }
    }
}