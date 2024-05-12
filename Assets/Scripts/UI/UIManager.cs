using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject riskBar;
    public GameObject manual;
    public GameObject muscleSelection;
    public GameObject popUpUI;

    [Header("Buttons")]
    [SerializeField] Button uiPopUpButton;
    [SerializeField] Button muscleSelectionButton;
    [SerializeField] Button riskBarButton;
    [SerializeField] Button manualButton;

    public bool isPopUp = false;
    bool isSelectMuscle = false;
    bool isSelectRiskBar = false;
    bool isSelectManual = false;
    private void Start()
    {
        uiPopUpButton.onClick.AddListener(() =>
        {
            isPopUp = !isPopUp;
        });

        muscleSelectionButton.onClick.AddListener(() =>
        {
            isSelectMuscle = !isSelectMuscle;
        });
        riskBarButton.onClick.AddListener(() =>
        {
            isSelectRiskBar = !isSelectRiskBar;
        });
        manualButton.onClick.AddListener(() =>
        {
            isSelectManual = !isSelectManual;
        });
    }
    private void Update()
    {
        popUpUI.SetActive(isPopUp);
        riskBar.SetActive(isSelectRiskBar);
        muscleSelection.SetActive(isSelectMuscle);
        manual.SetActive(isSelectManual);
    }
}
