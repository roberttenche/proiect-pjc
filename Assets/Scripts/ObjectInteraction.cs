using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Canvas ui;
    public Camera cam;

    //private static Color startcolor;
    private Transform focusPoint;
    private static Vector3 lastPosition;
    private static Quaternion lastRotation;
    public static bool focused = false;
    private static Color selectColor = new Color(177f / 255f, 196f / 255f, 201f / 255f);

    // Start is called before the first frame update
    void Start()
    {
        focusPoint = GetComponent<Transform>().GetChild(0).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") && focused == true)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            cam.GetComponent<Transform>().position = lastPosition;
            cam.GetComponent<Transform>().rotation = lastRotation;

            cam.GetComponent<PlayerController>().enabled = true;
            ui.enabled = true;

            focused = false;
        }
    }

    void OnMouseEnter()
    {
        if (focused == false)
        {
            //startcolor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = selectColor;
        }
    }

    void OnMouseExit()
    {
        if (focused == false)
        {
            //GetComponent<Renderer>().material.color = startcolor;
        }
    }

    public void focus()
    {
        if ( focused == false)
        {
            cam.GetComponent<PlayerController>().enabled = false;
            ui.enabled = false;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //GetComponent<Renderer>().material.color = startcolor;

            lastPosition = cam.GetComponent<Transform>().position;
            lastRotation = cam.GetComponent<Transform>().rotation;

            cam.GetComponent<Transform>().position = focusPoint.position;
            cam.GetComponent<Transform>().rotation = focusPoint.rotation;

            focused = true;
        }

    }

    public bool isFocused()
    {
        return focused;
    }
}
