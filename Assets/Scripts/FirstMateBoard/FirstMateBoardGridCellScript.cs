using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMateBoardGridCellScript : MonoBehaviour
{

    public string Resource;

    void Start()
    {
        GameObject childPlane = transform.GetChild(0).gameObject;
        Renderer childPlaneRenderer = childPlane.transform.GetComponent<Renderer>();

        childPlaneRenderer.sharedMaterial = Resources.Load<Material>(string.Format(Resource + "/Materials/{0}", transform.gameObject.name));

    }
}
