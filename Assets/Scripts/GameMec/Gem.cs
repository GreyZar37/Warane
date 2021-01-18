using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    // Start is called before the first frame update

    public Texture2D cursorArrow;
    public Vector2 offset;

    void Start()

   
    {
        Cursor.SetCursor(cursorArrow, offset, CursorMode.ForceSoftware);
    }

  
}
