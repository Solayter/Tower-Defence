using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Gameplay
    {
        private Map map = Map.getInstance();
        

        public void Process()
        {
            Actions();
            
        }
        public void SpawnMelee(bool enemy,int X, int Y)
        {
            map.units.Add(map.meleeSpawner.Create(enemy, X, Y));
        }
        public void SpawnRange(bool enemy,int X, int Y)
        {
            map.units.Add(map.rangeSpawner.Create(enemy, X, Y));
        }
        public void SpawnBallista(bool enemy, int X, int Y)
        {
            map.units.Add(map.ballistaSpawner.Create(enemy, X, Y));
        }
        public void SpawnTower(bool enemy, int X, int Y)
        {
            map.builds.Add(map.towerSpawner.Create(enemy, X, Y));
        }
        public void SpawnCastle(bool enemy, int X, int Y)
        {
            map.builds.Add(map.castleSpawner.Create(enemy, X, Y));
        }
        public void Actions()
        {
            foreach (var unit in map.units)
            {
                unit.Action();
            }
        }

        public void Changer(ref Entity patient, int hp,  int damage)
        {
            patient.hp = hp;
            patient.damage = damage;
        }
    }
}
