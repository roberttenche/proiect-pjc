using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Transform focusPoint;

    private Vector3 lastPosition;
    private Quaternion lastRotation;
    private Vector3 lastLocalScale;

    private bool focused = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && focused == false)
        {
            this.GetComponent<PlayerController>().enabled = false;

            lastPosition = transform.position;
            lastRotation = transform.rotation;

            transform.position = focusPoint.position;
            transform.rotation = focusPoint.rotation;

            focused = true;
        }

        if (Input.GetKeyDown("escape") && focused == true)
        {
            transform.position = lastPosition;
            transform.rotation = lastRotation;

            this.GetComponent<PlayerController>().enabled = true;

            focused = false;
        }
    }
}
