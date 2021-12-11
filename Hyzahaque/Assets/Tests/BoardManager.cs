using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour
{

    [HideInInspector]
    BoardManager instance = null;

    [SerializeField] int columns = 0;
    [SerializeField] int rows = 0;

    [SerializeField] Tilemap terrain;
    [SerializeField] Tilemap border;
    [SerializeField] TileBase[] floorTiles;
    [SerializeField] TileBase[] borderTiles;
    [SerializeField] Grid grid;

    private List<Vector2Int> gridPositions = new List<Vector2Int>();
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void InitializeList()
    {
        gridPositions.Clear();
        for (int x = -1; x < columns - 1; x++)
        {
            for (int y = -1; y < rows - 1; y++)
            {
                gridPositions.Add(new Vector2Int(x, y));
            }
        }
    }

    void BoardSetup()
    {
        for (int x = -1; x < columns + 1; x++)
        {
            for (int y = -1; y < rows + 1; y++)
            {
                terrain.RefreshAllTiles();
                border.RefreshAllTiles();

                Vector3Int tileToInstantiate = Vector3Int.zero;
                tileToInstantiate.Set(x, y, 0);

                if (x == -1 || x == columns || y == -1 || y == rows)
                {
                    border.SetTile(tileToInstantiate, borderTiles[Random.Range(0, floorTiles.Length)]);
                }
                else
                {
                    terrain.SetTile(tileToInstantiate, floorTiles[Random.Range(0, floorTiles.Length)]);
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BoardSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
