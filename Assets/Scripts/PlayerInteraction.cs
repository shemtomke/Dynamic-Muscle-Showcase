using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Dumbell 
    [Header("Lifting Dumbell")]
    public GameObject dumbell;

    [Header("Picking & Placing Objects")]
    public GameObject pickObject;

    [Header("Kicking Football")]
    public GameObject ball;

    [Header("Cricket")]
    public GameObject cricketBall;
    public GameObject cricketBat;

    [Header("Office")] 
    public GameObject chair;

    [Header("Automotive")]
    public GameObject car;

    // for example the chair the user should first check if the object is near to perform the action then allow to position the player
    // at a specific part
}
