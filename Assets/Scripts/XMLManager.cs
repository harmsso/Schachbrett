using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLManager : MonoBehaviour
{
    public static XMLManager ins;
    // Start is called before the first frame update
    void Start()
    {
      ins = this;
    }

    //list of Figures
    public FigureDatabase figureDB;

    public void SavePositions(){
      XmlSerializer serializer = new XmlSerializer(typeof(FigureDatabase));
      FileStream stream = new FileStream(Application.dataPath +"/XML/figureStartingPoint.xml", FileMode.Create);
      serializer.Serialize(stream, figureDB);
      stream.Close();
    }

    public void LoadPositions(){
      XmlSerializer serializer = new XmlSerializer(typeof(FigureDatabase));
      FileStream stream = new FileStream(Application.dataPath +"/XML/figureStartingPoint.xml", FileMode.Open);
      figureDB = serializer.Deserialize(stream) as FigureDatabase;
      stream.Close();
    }
}

[System.Serializable]
public class Figures {
  public string FigureName;
  public Vector3 startingPos;
}

[System.Serializable]
public class FigureDatabase{
  public List<Figures> list = new List<Figures>();
}
