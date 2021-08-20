using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private int counter;
 
    private void AddCount()
    {
        counter++;
    }

    // Update is called once per frame
    void Update(){
        AddCount();
        Debug.Log(counter);
        
    }
}
