using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{
    public string Resource;

    private int width = 15;
    private int height = 15;

    public GameObject gridCellPrefab;
    private GameObject[,] gameGrid;

    // Start is called before the first frame update
    void Start()
    {
        gameGrid = new GameObject[height, width];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                gameGrid[x, y] = Instantiate(gridCellPrefab, new Vector3(x, y), Quaternion.identity);
                gameGrid[x, y].transform.SetParent(transform,false);
                gameGrid[x, y].gameObject.name = string.Format("row-{0}-column-{1}", height - y , x + 1);
                gameGrid[x, y].GetComponent<GridCellScript>().Resource = Resource;
            }
        }
    }
}
