using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    public GameObject pickedObject;
    public Transform handPosition;

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
}
