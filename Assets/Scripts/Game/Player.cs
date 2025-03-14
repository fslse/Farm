using UnityEngine;
using QFramework;
using UnityEngine.Tilemaps;

namespace Farm.Game
{
    public partial class Player : ViewController
    {
        [SerializeField] private Grid _grid;
        [SerializeField] private Tilemap _tilemap;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var gridPosition = _grid.WorldToCell(transform.position);

                EasyGrid<SoilData> map = FindObjectOfType<GridController>().Map;

                if (gridPosition.x is >= 0 and < 10 && gridPosition.y is >= 0 and < 10)
                {
                    if (map[gridPosition.x, gridPosition.y] == null)
                    {
                        // 开垦
                        _tilemap.SetTile(gridPosition, FindObjectOfType<GridController>().Tile);
                        map[gridPosition.x, gridPosition.y] = new SoilData();
                    }
                    else if (map[gridPosition.x, gridPosition.y].HasPlant == false) // 没有植物
                    {
                        // 种植

                        /*var tileWorldPosition = _tilemap.CellToWorld(gridPosition);
                        tileWorldPosition.x += _grid.cellSize.x / 2;
                        tileWorldPosition.y += _grid.cellSize.y / 2;*/

                        var tileWorldPosition = _tilemap.GetCellCenterWorld(gridPosition);
                        ResController.Instance.SeedPrefab.Instantiate().Position(tileWorldPosition);
                        map[gridPosition.x, gridPosition.y].HasPlant = true;
                    }
                }
            }

            if (Input.GetMouseButtonDown(1))
            {
            }
        }
    }
}