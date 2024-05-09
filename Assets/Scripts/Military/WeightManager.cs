using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightManager : MonoBehaviour
{
    public GameObject weight;

    public Transform leftHandWeightPosition, rightHandWeightPosition;
    public Transform leftHand, rightHand;

    bool isLiftingWeight = false;

    GameObject leftWeight = null;
    GameObject rightWeight = null;

    StarterAssetsInputs assetsInputs;
    private void Start()
    {
        assetsInputs = FindObjectOfType<StarterAssetsInputs>();
    }
    
    private void Update()
    {
        if (assetsInputs.bicep && !isLiftingWeight)
        {
            leftWeight = Instantiate(weight);
            leftWeight.transform.SetParent(leftHand, false);
            leftWeight.transform.position = leftHandWeightPosition.position;
            leftWeight.transform.rotation = leftHandWeightPosition.rotation;

            rightWeight = Instantiate(weight);
            rightWeight.transform.SetParent(rightHand, false);
            rightWeight.transform.position = rightHandWeightPosition.position;
            rightWeight.transform.rotation = rightHandWeightPosition.rotation;

            isLiftingWeight = true;
        }

        if(!assetsInputs.bicep && isLiftingWeight)
        {
            // Destroy the weights
            Destroy(leftWeight);
            Destroy(rightWeight);

            isLiftingWeight=false;
        }
    }
}
