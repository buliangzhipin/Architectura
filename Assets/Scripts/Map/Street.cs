using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : MonoBehaviour
{
    private List<Tile> tiles = new List<Tile>();
    void Start()
    {
        GetTiles();
    }

    void GetTiles()
    {
        for (int i = 1; i < 9; i++)
        {
            var tile = this.transform.Find("Tile" + i.ToString()).GetComponent<Tile>();
            tiles.Add(tile);
            tile.SetStreet(this);
        }
    }

    public List<Tile> GetSelectableTile()
    {
        var selectable = new List<Tile>();
        foreach (var tile in tiles)
        {
            if (!tile.isBuilt)
            {
                selectable.Add(tile);
                break;
            }
            if (tile.destroyed)
            {
                selectable.Add(tile);
            }
        }
        return selectable;
    }
}
