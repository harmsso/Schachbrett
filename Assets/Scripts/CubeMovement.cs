using UnityEngine;
using UnityEditor;

public class CubeMovement : MonoBehaviour
{
  static Vector3 w = new Vector3(-1.0f,0,0);
  static Vector3 a = new Vector3(0,0,-1.0f);
  static Vector3 s = new Vector3(1.0f,0,0);
  static Vector3 d = new Vector3(0,0,1.0f);
    
    void Update()
    {
      if(Selection.activeGameObject != null){
         
      if (Input.GetKeyDown("w"))
      {
          //print("w was pressed");
          if(Physics.Raycast(Selection.activeGameObject.transform.position, w, 1) == false){
                    Selection.activeGameObject.transform.position += w;
          }
      }

      if (Input.GetKeyDown("a"))
      {
          //print("a was pressed");
          if(Physics.Raycast(Selection.activeGameObject.transform.position, a, 1) == false){
                    Selection.activeGameObject.transform.position += a;
          }
      }

      if (Input.GetKeyDown("d"))
      {
          //print("d was pressed");
          if(Physics.Raycast(Selection.activeGameObject.transform.position, d, 1) == false){
                    Selection.activeGameObject.transform.position += d;
          }
      }

      if (Input.GetKeyDown("s"))
      {
          //print("s was pressed");
          if(Physics.Raycast(Selection.activeGameObject.transform.position, s, 1) == false){
                    Selection.activeGameObject.transform.position += s;
          }
      }
    }
  }
}
