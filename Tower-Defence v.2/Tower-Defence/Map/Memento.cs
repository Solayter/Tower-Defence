using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tower_Defence
{
    public static class Memento
    {
        public static string SaveFile()
        {
            string file = "";
            
            Dictionary<string, Action> dic = new Dictionary<string, Action>();
            
            for (int j = 0; j < Map.getInstance().yY; j++)
            {
                //file += "\n";
                for (int i = 0; i < Map.getInstance().xX; i++)
                {
                    Type p = Map.getInstance().field.GetType();
                    //switch (p)
                    {
                        
                    }
                    if (Map.getInstance().field[i, j].obj != null)
                        if (!Map.getInstance().field[i, j].obj.enemy)
                        {
                            if (Map.getInstance().field[i, j].obj is Melee)
                            {
                                file += "A1" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Range)
                            {
                                file += "A2" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Ballista)
                            {
                                file += "A3" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Tower)
                            {
                                file += "A4" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Castle)
                            {
                                file += "A5" + " ";
                            }
                        }
                        else
                        {
                            if (Map.getInstance().field[i, j].obj is Melee)
                            {
                                file += "E1" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Range)
                            {
                                file += "E2" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Ballista)
                            {
                                file += "E3" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Tower)
                            {
                                file += "E4" + " ";
                            }
                            if (Map.getInstance().field[i, j].obj is Castle)
                            {
                                file += "E5" + " ";
                            }
                        }

                    else
                        file += 0 + " ";
                }
            }
            return file;
        }
        public static void OpenFile(string open)
        {
            FileStream f = new FileStream(open, FileMode.Open, FileAccess.Read);
            StreamReader f2 = new StreamReader(f);
            string file = f2.ReadLine();
            string[] str = file.Split(' ');
            int a = 0;
            Map.getInstance().builds.Clear();
            Map.getInstance().units.Clear();

            Dictionary<string, Action<int,int>> dic = new Dictionary<string, Action<int, int>>();

            {
                dic.Add("A1", (i, j) => { Map.getInstance().units.Add(Map.getInstance().meleeSpawner.Create(false, i, j)); });
                dic.Add("A2", (i, j) => { Map.getInstance().units.Add(Map.getInstance().rangeSpawner.Create(false, i, j)); });
                dic.Add("A3", (i, j) => { Map.getInstance().units.Add(Map.getInstance().ballistaSpawner.Create(false, i, j)); });
                dic.Add("A4", (i, j) => { Map.getInstance().builds.Add(Map.getInstance().towerSpawner.Create(false, i, j)); });
                dic.Add("A5", (i, j) => { Map.getInstance().builds.Add(Map.getInstance().castleSpawner.Create(false, i, j)); });
                dic.Add("E1", (i, j) => { Map.getInstance().units.Add(Map.getInstance().meleeSpawner.Create(true, i, j)); });
                dic.Add("E2", (i, j) => { Map.getInstance().units.Add(Map.getInstance().rangeSpawner.Create(true, i, j)); });
                dic.Add("E3", (i, j) => { Map.getInstance().units.Add(Map.getInstance().ballistaSpawner.Create(true, i, j)); });
                dic.Add("E4", (i, j) => { Map.getInstance().builds.Add(Map.getInstance().towerSpawner.Create(true, i, j)); });
                dic.Add("E5", (i, j) => { Map.getInstance().builds.Add(Map.getInstance().castleSpawner.Create(true, i, j)); });
                dic.Add("0", (i, j) => { Map.getInstance().field[i, j].obj = null; Map.getInstance().field[i, j].pass = true; });
            }

            for (int j = 0; j < Map.getInstance().yY; j++)
                for (int i = 0; i < Map.getInstance().xX; i++)
                    dic[str[a++]](i,j);

            f2.Close();
            f.Close();
        }
    }
}
