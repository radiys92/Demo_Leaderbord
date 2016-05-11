using System.Collections.Generic;
using System.Linq;

public class ServerBridge : CharpSingleton<ServerBridge>
{
    private UserData _userStatsCahce = null;
    private TopData _topCache = null;

    public UserStats GetCurrentUserStats(FiltersInfo filtersInfo)
    {
        if (_userStatsCahce == null) LoadUserData();
        return _userStatsCahce[filtersInfo];
    }

    public UserTopData[] GetTop10Data(FiltersInfo filtersInfo)
    {
        if (_topCache == null) LoadTopData();
        return _topCache[filtersInfo];
    }

    private void LoadUserData()
    {
        _userStatsCahce = UserData.Dummy;
    }

    private void LoadTopData()
    {
        _topCache = TopData.Dummy;
    }
}

public class TopData : Dictionary<FiltersInfo, UserTopData[]>
{
    public static TopData Dummy
    {
        get
        {
            var data = new TopData();
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Easy, PlayerStatus = PlayerStatus.All },
                (new int[10]).Select(a=>UserTopData.Dummy).ToArray());
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Medium, PlayerStatus = PlayerStatus.All },
                (new int[10]).Select(a => UserTopData.Dummy).ToArray());
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Hard, PlayerStatus = PlayerStatus.All },
                (new int[10]).Select(a => UserTopData.Dummy).ToArray());
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Easy, PlayerStatus = PlayerStatus.Brookie },
                (new int[10]).Select(a => UserTopData.Dummy).ToArray());
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Medium, PlayerStatus = PlayerStatus.Brookie },
                (new int[10]).Select(a => UserTopData.Dummy).ToArray());
            data.Add(new FiltersInfo() { Difficulty = Difficulty.Hard, PlayerStatus = PlayerStatus.Brookie },
                (new int[10]).Select(a => UserTopData.Dummy).ToArray());
            return data;
        }
    }
}

public class UserData : Dictionary<FiltersInfo, UserStats>
{
    public static UserData Dummy
    {
        get
        {
            var data = new UserData();
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Easy, PlayerStatus = PlayerStatus.All},
                UserStats.Dummy);
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Medium, PlayerStatus = PlayerStatus.All},
                UserStats.Dummy);
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Hard, PlayerStatus = PlayerStatus.All},
                UserStats.Dummy);
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Easy, PlayerStatus = PlayerStatus.Brookie},
                UserStats.Dummy);
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Medium, PlayerStatus = PlayerStatus.Brookie},
                UserStats.Dummy);
            data.Add(new FiltersInfo() {Difficulty = Difficulty.Hard, PlayerStatus = PlayerStatus.Brookie},
                UserStats.Dummy);
            return data;
        }
    }
}