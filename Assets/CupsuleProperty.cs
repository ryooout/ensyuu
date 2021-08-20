using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupsuleProperty: MonoBehaviour
{
    [SerializeField] Seriali Seriali;
    private void Start()
    {
        Debug.Log("最大値は" + Seriali.MaxCount);
    }
    private void Update()
    {
        if (Seriali.Count % 100 == 0)
        {
            Debug.Log("100で割り切れた");
        }
    }
}


