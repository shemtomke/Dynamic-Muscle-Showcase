using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{
    public GameObject player;

    [Header("Start Driving")]
    public Transform steeringPlayerPosition;

    [Header("Stop Driving")]
    public Transform exitCarPosition;

    bool isEnterCar = false;

    StarterAssetsInputs assetsInputs;
    private void Start()
    {
        assetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    private void Update()
    {
        if(assetsInputs.drive && isEnterCar)
        {
            player.transform.position = steeringPlayerPosition.position;
            player.transform.rotation = steeringPlayerPosition.rotation;

            isEnterCar = true;
        }
        else
        {
            player.transform.position = steeringPlayerPosition.position;
            player.transform.rotation = steeringPlayerPosition.rotation;

            isEnterCar = false;
        }
    }
}
