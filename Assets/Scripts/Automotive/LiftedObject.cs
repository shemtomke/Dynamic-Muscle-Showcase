using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftedObject : MonoBehaviour
{
    public GameObject tyre;
    public Transform playerHandsPosition;

    [Header("Tyre Position & Rotation")]
    public Vector3 defaultPos;
    public Vector3 defaultRot;

    [Header("Tyre Position & Rotation - Lift")]
    public Vector3 liftPos;
    public Vector3 liftRot;

    StarterAssetsInputs starterAssetsInputs;

    public GameObject player;

    bool isLiftedPart = false;
    bool isDetectedObject = false;

    [Header("Player Position & Rotation")]
    public Vector3 playerLiftPosition;
    public Vector3 playerLiftRotation;

    ThirdPersonController thirdPersonController;

    private void Start()
    {
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    private void Update()
    {
        if (starterAssetsInputs.liftPart && !isLiftedPart && !isDetectedObject)
        {
            player.transform.position = playerLiftPosition;
            Quaternion playerRot = Quaternion.Euler(playerLiftRotation);
            player.transform.rotation = playerRot;
            
            isLiftedPart = true;
        }

        if (thirdPersonController.isStartLift)
        {
            tyre.transform.position = liftPos;
            Quaternion rotation = Quaternion.Euler(liftRot);
            tyre.transform.rotation = rotation;

            tyre.transform.SetParent(playerHandsPosition, false);

            thirdPersonController.isStartLift = false;
        }

        if (thirdPersonController.isEndLift)
        {
            tyre.transform.SetParent(null);
            tyre.transform.position = defaultPos;
            Quaternion rotation = Quaternion.Euler(defaultRot);
            tyre.transform.rotation = rotation;

            thirdPersonController.isEndLift = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDetectedObject = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isDetectedObject = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDetectedObject = false;
        }
    }
}
