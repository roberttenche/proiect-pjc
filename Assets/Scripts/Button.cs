using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{

    public Camera currentPlayerCamera;
    public GameObject currentCapitanBoardPrefab;
    public GameObject currentFirstMatePrefab;
    public GameObject currentMoveDirection;

    public Camera otherPlayerCamera;
    public GameObject otherFirstMatePrefab;
    public GameObject otherCapitanBoardPrefab;
    public GameObject otherMoveDirection;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        if (currentCapitanBoardPrefab.GetComponent<CapitanBoard>().direction == "")
        {
            return;
        }

        currentCapitanBoardPrefab.GetComponent<CapitanBoard>().enabled = false;
        currentCapitanBoardPrefab.GetComponent<ObjectInteraction>().enabled = false;

        currentPlayerCamera.enabled = false;
        currentPlayerCamera.GetComponent<PlayerController>().enabled = false;
        currentCapitanBoardPrefab.GetComponent<CapitanBoard>().submarineObject.GetComponent<Submarine>().movements = 1;

        currentMoveDirection.SetActive(true);

        currentMoveDirection.GetComponent<TMP_Text>().text = currentCapitanBoardPrefab.GetComponent<CapitanBoard>().direction;
        currentCapitanBoardPrefab.GetComponent<CapitanBoard>().direction = "";

        currentFirstMatePrefab.GetComponent<FirstMateBoard>().enabled = false;
        currentFirstMatePrefab.GetComponent<ObjectInteraction>().enabled = false;











        otherCapitanBoardPrefab.GetComponent<CapitanBoard>().enabled = true;
        otherCapitanBoardPrefab.GetComponent<ObjectInteraction>().enabled = true;

        otherPlayerCamera.enabled = true;
        otherPlayerCamera.GetComponent<PlayerController>().enabled = true;
        otherMoveDirection.SetActive(false);

        otherFirstMatePrefab.GetComponent<FirstMateBoard>().enabled = true;
        otherFirstMatePrefab.GetComponent<ObjectInteraction>().enabled = true;


    }

}
