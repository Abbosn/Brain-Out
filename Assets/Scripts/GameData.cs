[System.Serializable]
public class GameData
{
    private static GameData gameData = null;
    protected GameData()
    {

    }
    public static GameData GameDataInitialize()
    {
        if (gameData == null)
            gameData = new GameData();
        return gameData;
    }

    /*public void GameDataCopyWith(GameData instance)
    {
        this.playerLevel = instance.playerLevel;
        this.countOfCompletedLevels = instance.countOfCompletedLevels;
        this.lights = instance.lights;   
    }*/
    public int playerLevel;
    public int countOfCompletedLevels = 0;
    public int lights;
    
}