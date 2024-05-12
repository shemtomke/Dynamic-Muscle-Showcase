using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryBox : MonoBehaviour
{
    [SerializeField] GameObject box;

    [Header("Player Transform")]
    public GameObject playerBoxPosition;
    public Transform boxCarryPosition;

    bool isCarry = false;
    bool isPlaceBox = false;

    StarterAssetsInputs assetsInputs;
    ThirdPersonController thirdPersonController;
    private void Start()
    {
        assetsInputs = FindObjectOfType<StarterAssetsInputs>();
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }
    private void Update()
    {
        // Carry
        if(assetsInputs.carry && !isCarry)
        {
            // Place Box in the Players Hands
            box.transform.position = Vector3.zero;
            box.transform.SetParent(boxCarryPosition, false);
            Rigidbody boxBody = box.GetComponent<Rigidbody>();

            boxBody.useGravity = false;
            boxBody.constraints = RigidbodyConstraints.FreezePosition;

            isCarry = true;
        }

        // Place it - When Carry is false
        if (!assetsInputs.carry && !isPlaceBox && isCarry)
        {
            isPlaceBox = true;
            isCarry = false;
        }

        if (thirdPersonController.isPlaceBox)
        {
            Debug.Log("Start Placing!");
            box.transform.SetParent(null);
            Rigidbody boxBody = box.GetComponent<Rigidbody>();
            boxBody.constraints = RigidbodyConstraints.None;
            boxBody.useGravity = true;

            thirdPersonController.isPlaceBox = false;
        }
    }
}
