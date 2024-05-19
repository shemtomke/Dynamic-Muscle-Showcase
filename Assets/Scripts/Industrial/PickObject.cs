using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    public GameObject pickedObject;
    public Transform handPosition;

    public bool isStartedPicking = false;
    bool isPick = false;
    StarterAssetsInputs assetsInputs;
    ThirdPersonController thirdPersonController;
    private void Start()
    {
        assetsInputs = FindObjectOfType<StarterAssetsInputs>();
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }
    private void Update()
    {
        if(assetsInputs.pick && !isPick)
        {
            isPick = true;
        }

        if(thirdPersonController.isPickObject)
        {
            pickedObject.transform.SetParent(handPosition, false);
            thirdPersonController.isPickObject = false;
        }

        if(thirdPersonController.isDropObject)
        {
            pickedObject.transform.SetParent(null);
            thirdPersonController.isDropObject = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isStartedPicking = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isStartedPicking = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isStartedPicking = false;
        }
    }
}
