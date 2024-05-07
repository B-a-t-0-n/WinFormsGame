using WinFormGame.Game.GameFormElement;

namespace WinFormGame.Game
{
    public class Map
    {
        public Panel PlayZone { get; set; }
        public Panel Header { get; set; }
        
        public Map(Panel playZone, Panel header, Block?[,] map) 
        {
            PlayZone = playZone;
            Header = header;
            LoadMap(map);
        }

        public void LoadMap(Block?[,] map)
        {
            //метод отпределения ширины и высоты блоков
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j]!.Width = PlayZone.Width / map.GetLength(1);
                    map[i, j]!.Height = PlayZone.Height / map.GetLength(0);
                    map[i, j]!.Location = new Point(j * map[i, j]!.Width, i * map[i, j]!.Height);
                }
            }

            //
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    PlayZone!.Controls.Add(map[i, j]);
                }
            }
        }
    }
}
