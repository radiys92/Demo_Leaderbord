public class UserTopData
{
    public static UserTopData Dummy
    {
        get
        {
            return new UserTopData()
            {
                IconId = UnityEngine.Random.Range(0, 9),
                Score = 123245,
                UserName = "Olga Pupkina"
            };
        }
    }

    public int IconId { get; set; }
    public string UserName { get; set; }
    public long Score { get; set; }
}