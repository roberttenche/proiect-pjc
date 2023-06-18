using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMateBoard : MonoBehaviour
{
    public string Resource;

    private int width = 15;
    private int height = 15;

    public GameObject gridCellPrefab;
    private GameObject[,] gameGrid;

    private int[,] enemyMovements;

    // Start is called before the first frame update
    void Start()
    {
        gameGrid = new GameObject[height + 1, width + 1];


        for (int y = 1; y <= height; y++)
        {
            for (int x = 1; x <= width; x++)
            {
                GameObject gridCell = Instantiate(gridCellPrefab, new Vector3(x, y), Quaternion.identity);
                gridCell.transform.SetParent(transform, false);
                gridCell.name = string.Format("row-{0}-column-{1}", height - y + 1, x);
                gridCell.GetComponent<FirstMateBoardGridCellScript>().Resource = Resource;

                gridCell.GetComponentInChildren<FirstMateBoardInteractableGridCell>().grid_x = x;
                gridCell.GetComponentInChildren<FirstMateBoardInteractableGridCell>().grid_y = y;

                gameGrid[y, x] = gridCell;

            }
        }

        setupLandTiles();

    }

    private void setupLandTiles()
    {
        gameGrid[1, 4].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 3].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 7].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 9].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[2, 14].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[3, 1].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[3, 13].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 3].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 8].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[4, 12].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[5, 4].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 4].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 8].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 12].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 13].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[7, 14].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 2].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 4].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[8, 7].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 2].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 4].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 7].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[9, 9].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[12, 9].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 3].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 9].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[13, 13].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 3].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 7].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
        gameGrid[14, 14].gameObject.GetComponentInChildren<FirstMateBoardInteractableGridCell>().isLand = true;
    }
}
