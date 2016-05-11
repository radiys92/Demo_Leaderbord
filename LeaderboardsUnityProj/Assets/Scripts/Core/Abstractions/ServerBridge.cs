using System.Collections.Generic;

public class ServerBridge : CharpSingleton<ServerBridge>
{
    private CacheMachine<FiltersInfo, UserStats> _usersCache = new CacheMachine<FiltersInfo, UserStats>();
    private CacheMachine<FiltersInfo, UserTopData[]> _topCache = new CacheMachine<FiltersInfo, UserTopData[]>();

    protected override void OnInit()
    {
        base.OnInit();

        _usersCache.ExpireTimeSeconds = 60; // load every 60 secs
        _topCache.ExpireTimeSeconds = 60*60*8; // load every 8 hours
    }

    public UserStats GetCurrentUserStats(FiltersInfo filtersInfo)
    {
        var data = _usersCache.Get(filtersInfo) ?? LoadUserStats(filtersInfo);
        return data;
    }

    public UserTopData[] GetTop10Data(FiltersInfo filtersInfo)
    {
        var data = _topCache.Get(filtersInfo) ?? LoadTopData(filtersInfo);
        return data;
    }

    private UserTopData[] LoadTopData(FiltersInfo filtersInfo)
    {
        var res = new List<UserTopData>();
        for (var i = 0; i < 10; i++)
        {
            res.Add(UserTopData.Dummy);
        }
        _topCache.Set(filtersInfo, res.ToArray());
        return res.ToArray();
    }

    private UserStats LoadUserStats(FiltersInfo filtersInfo)
    {
        var res = UserStats.Dummy;
        _usersCache.Set(filtersInfo, res);
        return res;
    }
}