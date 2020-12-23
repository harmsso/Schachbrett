using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void createGame(){
      Vector3 scaleFactor = new Vector3(0.5f,0.5f,0.5f);

      XMLManager.ins.LoadPositions();

      displayWhiteSide(scaleFactor);

      displayBlackSide(scaleFactor);

      //XMLManager.ins.SavePositions();
    }

    public void displayWhiteSide(Vector3 scaleFactor){
      foreach (Figures figure in XMLManager.ins.figureDB.list){
        var newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        newCube.transform.localScale = scaleFactor;
        newCube.transform.position = figure.startingPos;
      }
    }

    public void displayBlackSide(Vector3 scaleFactor){
      foreach (Figures figure in XMLManager.ins.figureDB.list){
        var newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.GetComponent<Renderer>().material.color = new Color(0,0,0,0);
        newCube.transform.localScale = scaleFactor;
        newCube.transform.position = new Vector3(-figure.startingPos.x, 0.4f, -figure.startingPos.z);
      }
    }
}
