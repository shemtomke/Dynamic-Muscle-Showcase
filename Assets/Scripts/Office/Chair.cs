using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    StarterAssetsInputs starterAssetsInputs;

    public GameObject player;

    bool isSitted = false;

    [Header("Player Position & Rotation")]
    public Vector3 playerSitPosition;
    public Vector3 playerSitRotation;
    public Vector3 playerExitChairPosition;
    public Vector3 playerExitChairRotation;

    private void Start()
    {
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit Player!");
            // Perform animation of the player to sit
            if(starterAssetsInputs.sit)
            {
                other.gameObject.transform.position = playerSitPosition;

                Quaternion rotation = Quaternion.Euler(playerSitRotation);
                other.gameObject.transform.rotation = rotation;

                isSitted = true;
                Debug.Log("Sit is true!");
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Perform animation of the player to sit
            if (!starterAssetsInputs.sit && isSitted)
            {
                other.gameObject.transform.position = playerExitChairPosition;

                Quaternion rotation = Quaternion.Euler(playerExitChairRotation);
                other.gameObject.transform.rotation = rotation;

                isSitted = false;
            }

            // Perform animation of the player to sit
            if (starterAssetsInputs.sit)
            {
                other.gameObject.transform.position = playerSitPosition;

                Quaternion rotation = Quaternion.Euler(playerSitRotation);
                other.gameObject.transform.rotation = rotation;

                isSitted = true;
                Debug.Log("Sit is true!");
            }
        }
    }
}
