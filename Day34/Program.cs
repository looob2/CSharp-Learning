MonsterManager monsterManager = new();
foreach (string monster in monsterManager.GetMonsters())
{
    Console.WriteLine(monster);
}

class MonsterManager
{
    private List<string> monsters = new()
    {
        "史莱姆",
        "僵尸",
        "哥布林"
    };

    public IEnumerable<string> GetMonsters()
    {
        foreach (string monster in monsters)
        {
            yield return monster;
        }
    }
}