using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication2.Entities;

namespace WebApplication2.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        public List<Employee> Employees { get; set; } = new List<Employee> {

              new Employee
                    {
                        Id=1,
                         CityId=1,
                          Firstname="Eynal",
                           Lastname="Baxshiyev",
                            Point=88
                    },
                    new Employee
                    {
                        Id=2,
                         CityId=2,
                          Firstname="Nigar",
                          Lastname="Mustafazade",
                          Point=56
                    },
                    new Employee
                    {
                        Id=3,
                         CityId=3,
                          Firstname="Shireli",
                           Lastname="Nuriyev",
                            Point=99
                    },
                    new Employee
                    {
                        Id=4,
                         CityId=4,
                          Firstname="Resul",
                           Lastname="Sebsiyev",
                            Point=66
                    }
};

        private const string ListCountAttribute = "count";
        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }

        private const string SortAttribute = "sort";
        [HtmlAttributeName(SortAttribute)]
        public string Sort { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = Employees.Take(ListCount);
            if (Sort == "a-z")
            {
                query=query.OrderBy(x => x.Firstname);
            }
            else if (Sort == "z-a")
            {
                query=query.OrderByDescending(x => x.Firstname);
            }

            StringBuilder sb=new StringBuilder();
            foreach (var employee in query)
            {
                sb.AppendFormat("<h2><a href='/home/GetEmployee/{0}'>{1}</a></h2>", employee.Id, employee.Firstname);
            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
