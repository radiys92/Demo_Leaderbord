public class OptionsBridge:CharpSingleton<OptionsBridge>
{
    public UserStats GetUserStats()
    {
        return ServerBridge.Instance.GetUserStats();
    }
}