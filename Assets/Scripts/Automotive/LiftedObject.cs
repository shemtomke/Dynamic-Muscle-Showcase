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

    private void Start()
    {
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    private void Update()
    {
        if (starterAssetsInputs.liftPart && !isLiftedPart && isDetectedObject)
        {
            player.transform.position = playerLiftPosition;

            // Place the Object at the hands
            tyre.transform.SetParent(playerHandsPosition, false);
            tyre.transform.position = liftPos;

            tyre.transform.position = liftPos;
            Quaternion rotation = Quaternion.Euler(liftRot);
            tyre.transform.rotation = rotation;

            isLiftedPart = true;
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
