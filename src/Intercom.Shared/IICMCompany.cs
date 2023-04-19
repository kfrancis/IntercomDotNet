namespace Intercom.Shared;

public interface IICMCompany
{
    string CompanyId { get; set; }
    DateTime CreatedAt { get; set; }
    Dictionary<string, object> CustomAttributes { get; set; }
    Decimal MonthlySpend { get; set; }
    string Name { get; set; }
    string Plan { get; set; }
}