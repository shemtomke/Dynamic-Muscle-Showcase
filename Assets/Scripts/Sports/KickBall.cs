using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{
    public GameObject player;
    public GameObject ball;

    public Transform ballPosition;

    StarterAssetsInputs starterAssetsInputs;
    ThirdPersonController thirdPersonController;

    private void Start()
    {
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }
    private void Update()
    {
        if(thirdPersonController.isKickBall)
        {

        }
    }
}
