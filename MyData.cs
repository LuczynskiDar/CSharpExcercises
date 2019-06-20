using System.ComponentModel.DataAnnotations;

namespace CSharpExcercises
{
    public class MyData
    {
        [StringLength(10, MinimumLength = 6)]
        public string Name { get; set; }
        public string Surname { get; set; }

        [ReportData(ErrorMessage = "Somethig")]
        public int Age { get; set; }
    }
}