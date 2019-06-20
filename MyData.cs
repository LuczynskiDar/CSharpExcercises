namespace CSharpExcercises
{
    public class MyData
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [ReportData]
        public int Age { get; set; }
    }
}