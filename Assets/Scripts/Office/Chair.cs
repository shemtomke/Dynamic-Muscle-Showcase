using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public static Chair Instance;

    StarterAssetsInputs starterAssetsInputs;

    public GameObject player;

    public bool isSitted = false;
    public bool canSit = false;

    [Header("Player Position & Rotation")]
    public Transform playerSitTransform;
    public Transform playerExitChairTransform;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit Player!");
            canSit = true;
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
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSit = true;
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
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSit = false;
        }
    }
}
