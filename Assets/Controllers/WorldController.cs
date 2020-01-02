using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    // Statische Variablen
    public static WorldController INSTANCE;

    // Öffentliche Variablen
    public GameObject GrassTile;
    public GameObject SandTile;
    public GameObject WaterTile;

    // Member Variablen
    World world;
    Dictionary<Tile, GameObject> tileObjectMap;

    // Properties
    public World World { get => world; private set => world = value; }
    public Dictionary<Tile, GameObject> TileObjectMap { get => tileObjectMap; set => tileObjectMap = value; }

    // Start is called before the first frame update
    void Start()
    {
        INSTANCE = this;
        TileObjectMap = new Dictionary<Tile, GameObject>();

        GenerateWorld();
    }

    void GenerateWorld()
    {
        World = new World(10, 10);
        foreach (var tile in World.Tiles)
        {
            GameObject go;

            switch (tile.Type)
            {
                case Tile.TileType.Grass:
                    go = Instantiate(GrassTile, new Vector3(tile.X, 0, tile.Y), Quaternion.identity);
                    break;
                case Tile.TileType.Sand:
                    go = Instantiate(SandTile, new Vector3(tile.X, 0, tile.Y), Quaternion.identity);
                    break;
                case Tile.TileType.Water:
                    go = Instantiate(WaterTile, new Vector3(tile.X, 0, tile.Y), Quaternion.identity);
                    break;
                default:
                    return;
            }

            go.transform.parent = transform;
            go.name = tile.X + "|" + tile.Y + "|" + tile.Type;
            tileObjectMap.Add(tile, go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
