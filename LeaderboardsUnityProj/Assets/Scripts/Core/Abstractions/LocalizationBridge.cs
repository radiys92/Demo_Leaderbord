using DataKeepers;

internal class LocalizationBridge : CharpSingleton<LocalizationBridge>
{
    public string LocalizeStatusFilterCaption(PlayerStatus playerStatus)
    {
        return string.Format("ONLY {0}", playerStatus.ToString().ToUpper());
    }
}