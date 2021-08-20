using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seriali: MonoBehaviour
{
    private int counter;
    [SerializeField] private int maxCount;
    [SerializeField] private int count;
    public int MaxCount { get => maxCount; }
    public int Count { get => count; }

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