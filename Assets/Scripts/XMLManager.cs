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

public enum Color{
  Weiss,
  Schwarz
}
