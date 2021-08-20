using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seriari : MonoBehaviour
{
    private int counter;
    [SerializeField] private int maxCount;
    public int MaxCount { get => maxCount; set => maxCount = value; }

    // Update is called once per frame
    private void AddCount()
    {
        if (maxCount >= counter)
        {
            counter++;
        }
    }

    private void Update()
    {
        AddCount();
        Debug.Log(counter);

    }
}