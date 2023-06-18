using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitanBoard : MonoBehaviour
{
    public string Resource;

    private int width = 15;
    private int height = 15;

    public GameObject gridCellPrefab;
    public GameObject submarinePrefab;
    public string direction = "";
    private GameObject[,] gameGrid;

    public GameObject submarineObject;

    // Start is called before the first frame update
    void Start()
    {

        gameGrid = new GameObject[height+1, width+1];


        for (int y = 1; y <= height; y++)
        {
            for (int x = 1; x <= width; x++)
            {
                GameObject gridCell = Instantiate(gridCellPrefab, new Vector3(x, y), Quaternion.identity);
                gridCell.transform.SetParent(transform, false);
                gridCell.name = string.Format("row-{0}-column-{1}", height - y + 1, x);
                gridCell.GetComponent<CapitanBoardGridCellScript>().Resource = Resource;

                gridCell.GetComponentInChildren<CapitanBoardInteractableGridCell>().grid_x = x;
                gridCell.GetComponentInChildren<CapitanBoardInteractableGridCell>().grid_y = y;

                gameGrid[y, x] = gridCell;

            }
        }

        setupLandTiles();

        int start_y = Random.Range(1, height);
        int start_x = Random.Range(1, width);

        // while the tile is a land tile, generate another starting position
        while (gameGrid[start_y, start_x].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand == true)
        {
            start_y = Random.Range(1, height);
            start_x = Random.Range(1, width);
        }

        submarineObject = Instantiate(submarinePrefab, new Vector3(0,0), Quaternion.identity);

        GameObject parent = gameGrid[start_y, start_x].gameObject;

        submarineObject.transform.SetParent(parent.transform);

        submarineObject.transform.localPosition = new Vector3();

        submarineObject.transform.localScale = new Vector3(0.015f, 0.015f, 0.015f);

        submarineObject.GetComponent<Submarine>().x = start_x;
        submarineObject.GetComponent<Submarine>().y = start_y;

    }

    private void setupLandTiles()
    {
        gameGrid[1, 4].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 3].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 7].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 9].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 14].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[3, 1].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[3, 13].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 3].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 8].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 12].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[5, 4].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 4].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 8].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 12].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 13].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 14].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 2].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 4].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 7].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 2].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 4].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 7].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 9].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[12, 9].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 3].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 9].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 13].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 3].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 7].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 14].gameObject.GetComponentInChildren<CapitanBoardInteractableGridCell>().isLand = true;
    }
}
