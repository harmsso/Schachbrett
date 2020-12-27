using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectClicker : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null || hit.transform.gameObject.tag != "Schachbrett")
                {
                    Selection.activeObject = hit.transform.gameObject;
                }
            }
        }
    }
}
