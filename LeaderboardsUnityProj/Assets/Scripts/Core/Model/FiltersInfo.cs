public struct FiltersInfo
{
    public PlayerStatus PlayerStatus;
    public Difficulty Difficulty;

    public override string ToString()
    {
        return string.Format("PlayerStatus: {0}, Difficulty: {1}", PlayerStatus, Difficulty);
    }
}