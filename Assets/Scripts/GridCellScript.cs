using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCellScript : MonoBehaviour
{

    public string Resource;

    void Start()
    {
        GameObject child = transform.GetChild(0).gameObject;
        Renderer rend = child.transform.GetComponent<Renderer>();
        rend.sharedMaterial = Resources.Load<Material>(string.Format(Resource + "/Materials/{0}", transform.gameObject.name));
    }
}
