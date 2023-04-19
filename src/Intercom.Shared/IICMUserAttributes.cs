namespace Intercom.Shared;

public interface IICMUserAttributes
{
    Collection<IICMCompany> Companies { get; set; }
    Dictionary<string, object> CustomAttributes { get; set; }
    string Email { get; set; }
    string LanguageOverride { get; set; }
    string Name { get; set; }
    string Phone { get; set; }
    DateTime SignedUpAt { get; set; }
    bool UnsubscribedFromEmails { get; set; }
    string UserId { get; set; }
}