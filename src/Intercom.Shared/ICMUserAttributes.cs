namespace Intercom.Shared;

public class ICMUserAttributes : IICMUserAttributes
{
    public Collection<IICMCompany> Companies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Dictionary<string, object> CustomAttributes { get; set; }
    public string Email { get; set; }
    public string LanguageOverride { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime SignedUpAt { get; set; }
    public bool UnsubscribedFromEmails { get; set; }
    public string UserId { get; set; }
}