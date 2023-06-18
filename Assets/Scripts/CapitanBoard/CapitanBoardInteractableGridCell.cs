using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitanBoardInteractableGridCell : MonoBehaviour
{
    public int grid_x = 0;
    public int grid_y = 0;

    public bool isLand = false;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        Transform captBoard = transform.parent.parent;


        if (captBoard.GetComponent<ObjectInteraction>().isFocused() == false)
        {
            captBoard.GetComponent<ObjectInteraction>().focus();
            return;
        }

        if (isLand)
        {
            return;
        }

        GameObject submarineObject = captBoard.GetComponent<CapitanBoard>().submarineObject;


        if (submarineObject.GetComponent<Submarine>().movements == 0)
        {
            return;
        }

        int subX = submarineObject.GetComponent<Submarine>().x;
        int subY = submarineObject.GetComponent<Submarine>().y;

        if (
            !
            (
                ((subX + 1 == grid_x || subX - 1 == grid_x) && ( subY == grid_y))
                ||
                ((subY + 1 == grid_y || subY - 1 == grid_y) && ( subX == grid_x))
            )
        )
        {
            return;
        }

        if (subX + 1 == grid_x)
        {
            captBoard.GetComponent<CapitanBoard>().direction = "EAST";
        }
        else if (subX - 1 == grid_x)
        {
            captBoard.GetComponent<CapitanBoard>().direction = "WEST";
        }

        if (subY + 1 == grid_y)
        {
            captBoard.GetComponent<CapitanBoard>().direction = "NORTH";
        }
        else if (subY - 1 == grid_y)
        {
            captBoard.GetComponent<CapitanBoard>().direction = "SOUTH";
        }

        submarineObject.transform.SetParent(transform);
        submarineObject.transform.localPosition = new Vector3();

        submarineObject.GetComponent<Submarine>().y = grid_y;
        submarineObject.GetComponent<Submarine>().x = grid_x;
        submarineObject.GetComponent<Submarine>().movements--;

    }

    private void OnMouseEnter()
    {
    }
}
