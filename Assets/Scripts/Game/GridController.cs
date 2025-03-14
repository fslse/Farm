using QFramework;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Farm.Game
{
    public partial class GridController : ViewController
    {
        [SerializeField] private TileBase _tile;

        private readonly EasyGrid<SoilData> _map = new(10, 10);

        public EasyGrid<SoilData> Map => _map;

        public TileBase Tile => _tile;

        private void Start()
        {
            /*_map[0, 0] = new SoilData();
            _map[0, 1] = new SoilData();
            _map[2, 2] = new SoilData();

            _map[0, 4] = new SoilData();
            _map[0, 5] = new SoilData();

            _map.ForEach((x, y, data) =>
            {
                if (data != null)
                {
                    Debug.Log(Tilemap.size);
                    Tilemap.SetTile(new Vector3Int(x, y), _tile);
                }
            });*/
        }
    }
}