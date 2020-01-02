using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public enum TileType
    {
        Grass, Sand, Water
    }

    // Member variables
    TileType type;
    int x;
    int y;
    World world;

    // Properties
    public TileType Type { get => type; private set => type = value; }
    public int X { get => x; private set => x = value; }
    public int Y { get => y; private set => y = value; }
    public World World { get => world; private set => world = value; }

    // Constructor
    public Tile(int x, int y, World world)
    {
        X = x;
        Y = y;
        World = world;
        DetermineTileType();
    }

    void DetermineTileType()
    {
        int r = Random.Range(0, 3);
        switch (r)
        {
            case 0:
                Type = TileType.Grass;
                break;
            case 1:
                Type = TileType.Sand;
                break;
            case 2:
                Type = TileType.Water;
                break;
            default:
                break;
        }
    }
}
