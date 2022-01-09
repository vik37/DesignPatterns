namespace OCPLibrary.Applicants
{
    public interface IApplicantModel
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        IAccounts AccountProccessor { get; set; }
    }
}