namespace Intercom.Shared;

public interface IIntercomService
{
    void EnableLogging();

    void HandleIntercomPushNotification(Dictionary<string, string> userInfo);

    void HideMessenger();

    bool IsIntercomPushNotification(Dictionary<string, string> userInfo);

    bool IsPlatformSupported();

    void LogEventWithName(string name);

    void LogEventWithName(string name, Dictionary<string, string> metaData);

    void Logout();

    void PresentConversationList();

    void PresentHelpCenter();

    void PresentMessageComposer(string initialMessage);

    void PresentMessageComposer();

    void PresentMessageComposerWithInitialMessage(string message);

    void PresentMessenger();

    void RegisterUnidentifiedUser();

    void RegisterUserWithEmail(string email);

    void RegisterUserWithUserId(string userId);

    void RegisterUserWithUserId(string userId, string email);

    void Reset();

    void SetBottomPadding(float bottomPadding);

    void SetDeviceToken(string deviceToken);

    void SetInAppMessagesVisible(bool visible);

    void SetLauncherVisible(bool visible);

    //nuint UnreadConversationCount { get; }
    void SetNeedsStatusBarAppearanceUpdate();

    void SetUserHash(string userHash);

    void UpdateUser(IICMUserAttributes userAttributes);
}