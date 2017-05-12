using System;
using System.Collections.Generic;
using System.IO;

namespace Tower_Defence
{
    public static class Memento
    {
        public static string SaveFile()
        {
            string file = "";
            Dictionary<Type, Action<string>> dicA = new Dictionary<Type, Action<string>>();
            Dictionary<Type, Action<string>> dicE = new Dictionary<Type, Action<string>>();
            {
                dicA.Add(typeof(Melee),     (str) => { file += "A1" + " "; });
                dicA.Add(typeof(Range),     (str) => { file += "A2" + " "; });
                dicA.Add(typeof(Ballista),  (str) => { file += "A3" + " "; });
                dicA.Add(typeof(Tower),     (str) => { file += "A4" + " "; });
                dicA.Add(typeof(Castle),    (str) => { file += "A5" + " "; });
                dicE.Add(typeof(Melee),     (str) => { file += "E1" + " "; });
                dicE.Add(typeof(Range),     (str) => { file += "E2" + " "; });
                dicE.Add(typeof(Ballista),  (str) => { file += "E3" + " "; });
                dicE.Add(typeof(Tower),     (str) => { file += "E4" + " "; });
                dicE.Add(typeof(Castle),    (str) => { file += "E5" + " "; });
            }
            
            for (int j = 0; j < Map.getInstance().yY; j++)
            {
                for (int i = 0; i < Map.getInstance().xX; i++)
                {
                    if (Map.getInstance().field[i, j].obj != null)
                    {
                        if (!Map.getInstance().field[i, j].obj.enemy)
                            dicA[Map.getInstance().field[i, j].obj.GetType()](file);
                        else
                            dicE[Map.getInstance().field[i, j].obj.GetType()](file);
                    }
                    else
                    {
                        file += 0 + " ";
                    }
                }
            }
            return file;
        }
        public static void OpenFile(string open, Gameplay game)
        {
            using (StreamReader reader = new StreamReader(open))
            {
                string file = reader.ReadLine();
                string[] str = file.Split(' ');
                int a = 0;
                Map.getInstance().builds.Clear();
                Map.getInstance().units.Clear();
                Dictionary<string, Action<int, int>> dic = new Dictionary<string, Action<int, int>>();
                {
                    dic.Add("A1", (i, j) => { game.SpawnMelee(false, i, j); });
                    dic.Add("A2", (i, j) => { game.SpawnRange(false, i, j); });
                    dic.Add("A3", (i, j) => { game.SpawnBallista(false, i, j); });
                    dic.Add("A4", (i, j) => { game.SpawnTower(false, i, j); });
                    dic.Add("A5", (i, j) => { game.SpawnCastle(false, i, j); });
                    dic.Add("E1", (i, j) => { game.SpawnMelee(true, i, j); });
                    dic.Add("E2", (i, j) => { game.SpawnRange(true, i, j); });
                    dic.Add("E3", (i, j) => { game.SpawnBallista(true, i, j); });
                    dic.Add("E4", (i, j) => { game.SpawnTower(true, i, j); });
                    dic.Add("E5", (i, j) => { game.SpawnCastle(true, i, j); });
                    dic.Add("0", (i, j) => { Map.getInstance().field[i, j].obj = null; Map.getInstance().field[i, j].pass = true; });
                }
                for (int j = 0; j < Map.getInstance().yY; j++)
                    for (int i = 0; i < Map.getInstance().xX; i++)
                        dic[str[a++]](i, j);
            }
        }
    }
}
