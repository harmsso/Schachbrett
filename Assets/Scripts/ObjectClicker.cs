﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{

  public static GameObject CurObject = null;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
          RaycastHit hit;
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

          if (Physics.Raycast(ray, out hit, 100.0f)) {
            if (hit.transform != null) {
              CurObject = hit.transform.gameObject;
              PrintName(hit.transform.gameObject);
            }
          }
        }
    }

    private void PrintName(GameObject go){
      print(go.name);
    }
}
