using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    // Member Variablen
    Tile[,] tiles;
    int width;
    int height;

    // Properties
    public Tile[,] Tiles { get => tiles; set => tiles = value; }
    public int Width { get => width; private set => width = value; }
    public int Height { get => height; private set => height = value; }

    // Constructor
    public World(int width, int height)
    {
        Tiles = new Tile[width,height];
        Width = width;
        Height = height;

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                Tiles[x, z] = new Tile(x, z, this);
            }
        }
    }
}
