using DataKeepers;

public class OptionsBridge:CharpSingleton<OptionsBridge>
{
    public UserStats GetUserStats()
    {
        return ServerBridge.GetUserStats();
    }
}