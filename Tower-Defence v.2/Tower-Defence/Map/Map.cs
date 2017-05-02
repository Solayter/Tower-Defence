using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defence
{
    public class Map
    {
        public List<Unit> units = new List<Unit>();
        public List<Building> builds = new List<Building>();
        const int X = 38, Y = 15;
        public int xX = X, yY = Y;
        public Cell[,] field = new Cell[X, Y];
        public UnitCreator meleeSpawner = new MeleeCreator();
        public UnitCreator rangeSpawner = new RangeCreator();
        public UnitCreator ballistaSpawner = new BallistaCreator();
        public BuildsCreator towerSpawner = new TowerCreator();
        public BuildsCreator castleSpawner = new CastleCreator();

        private static Map singleton;

        public static Map getInstance()
        {
            if (singleton != null)
            {
                return singleton;
            }
            else
            {
                singleton = new Map();
                return singleton;//new Map();
            }
        }
        private Map() { }

        public void BuildField()
        {
            for (int j = 0; j < Y; j++)//Объявлениие экземпляров клеток
                for (int i = 0; i < X; i++)
                    field[i, j] = new Cell(i,j);

            for (int i = 0; i < X; i++)
            {
                field[i, 0].pass = false;
                field[i, 0].edge = true;
            }
            for (int i = 0; i < X; i++)
            {
                field[i, Y - 1].pass = false;
                field[i, Y - 1].edge = true;
            }
            for (int i = 0; i < Y; i++)
            {
                field[0, i].pass = false;
                field[0, i].edge = true;
            }
            for (int i = 0; i < Y; i++)
            {
                field[X - 1, i].pass = false;
                field[X - 1, i].edge = true;
            }
            //В крайние клетки теперь нельзя пройти (pass == false)

            for (int a = 1; a < X-1; a++)
                for (int b= 1; b< Y-1; b++)
                {
                    if (field[a, b].pass)
                    {
                        field[a, b].related[0] = field[a - 1, b+ 1];
                        field[a, b].related[1] = field[a - 1, b- 1];
                        field[a, b].related[2] = field[a - 1, b];
                        field[a, b].related[3] = field[a, b- 1];
                        field[a, b].related[4] = field[a, b+ 1];
                        field[a, b].related[5] = field[a + 1, b];
                        field[a, b].related[6] = field[a + 1, b- 1];
                        field[a, b].related[7] = field[a + 1, b+ 1];
                    }
                }
        }
    }
}
