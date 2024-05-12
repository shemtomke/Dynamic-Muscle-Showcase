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
    public Transform playerSitTransform;
    public Transform playerExitChairTransform;

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
                other.gameObject.transform.position = playerSitTransform.position;
                other.gameObject.transform.rotation = playerSitTransform.rotation;

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
                other.gameObject.transform.position = playerExitChairTransform.position;
                other.gameObject.transform.rotation = playerExitChairTransform.rotation;

                isSitted = false;
            }

            // Perform animation of the player to sit
            if (starterAssetsInputs.sit)
            {
                other.gameObject.transform.position = playerSitTransform.position;
                other.gameObject.transform.rotation = playerSitTransform.rotation;

                isSitted = true;
                Debug.Log("Sit is true!");
            }
        }
    }
}
