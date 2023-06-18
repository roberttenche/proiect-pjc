using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMateBoardInteractableGridCell : MonoBehaviour
{
    public int grid_x = 0;
    public int grid_y = 0;

    public bool isLand = false;

    public Material cross;

    bool crossIsSet = false;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        Transform firstMateBoard = transform.parent.parent;


        if (firstMateBoard.GetComponent<ObjectInteraction>().isFocused() == false)
        {
            firstMateBoard.GetComponent<ObjectInteraction>().focus();
            return;
        }

        if (isLand)
        {
            return;
        }

        Renderer planeRenderer = transform.GetComponent<Renderer>();

        Material[] mats = planeRenderer.materials;

        if (crossIsSet == false)
        {
            mats[1] = cross;
        }
        else
        {
            mats[1] = null;
        }

        crossIsSet = !crossIsSet;

        planeRenderer.materials = mats;
    }

    private void OnMouseEnter()
    {
    }
}
