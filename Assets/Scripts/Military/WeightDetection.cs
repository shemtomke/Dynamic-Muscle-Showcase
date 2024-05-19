using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightDetection : MonoBehaviour
{
    public static WeightDetection Instance;

    private void Awake()
    {
        Instance = this;
    }
    public bool isCarryWeights = false;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCarryWeights = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCarryWeights = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCarryWeights = true;
        }
    }
}
