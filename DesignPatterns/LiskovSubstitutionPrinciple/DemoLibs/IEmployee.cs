namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public interface IEmployee
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        decimal Salery { get; set; }

        decimal CalculatePerHoureRate(int rank);
    }
}