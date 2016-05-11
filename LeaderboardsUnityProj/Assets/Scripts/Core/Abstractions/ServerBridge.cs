using System.Collections.Generic;

public class ServerBridge : CharpSingleton<ServerBridge>
{
    public UserStats GetCurrentUserStats(FiltersInfo filtersInfo)
    {
        return UserStats.Dummy;
    }

    public UserTopData[] GetTop10Data(FiltersInfo filtersInfo)
    {
        var res = new List<UserTopData>();
        for (var i = 0; i < 10; i++)
        {
            res.Add(UserTopData.Dummy);
        }
        return res.ToArray();
    }
}