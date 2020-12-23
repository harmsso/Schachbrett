using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown("w"))
      {
          //print("w was pressed");
          ObjectClicker.CurObject.transform.position += new Vector3(-1.0f,0,0);
      }

      if (Input.GetKeyDown("a"))
      {
          //print("a was pressed");
          ObjectClicker.CurObject.transform.position += new Vector3(0,0,-1.0f);
      }

      if (Input.GetKeyDown("d"))
      {
          //print("s was pressed");
          ObjectClicker.CurObject.transform.position += new Vector3(0,0,1.0f);
      }

      if (Input.GetKeyDown("s"))
      {
          //print("d was pressed");
          ObjectClicker.CurObject.transform.position += new Vector3(1.0f,0,0);
      }
    }
}
