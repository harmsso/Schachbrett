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
      //Vector3 scaleFactor = new Vector3(0.5f,0.5f,0.5f);

      displayWhiteSide();

      displayBlackSide();
    }

    public void displayWhiteSide(){
      foreach (Figures figure in XMLManager.ins.figureDB.list){
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        newCube.transform.position = figure.startingPos;
      }
    }

    public void displayBlackSide(){
      foreach (Figures figure in XMLManager.ins.figureDB.list){
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        newCube.transform.position = -(figure.startingPos);
      }
    }
}
