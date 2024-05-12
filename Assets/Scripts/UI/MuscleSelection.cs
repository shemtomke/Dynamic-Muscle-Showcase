using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuscleSelection : MonoBehaviour
{
    [SerializeField] Color highlightColor;
    public LayerMask targetLayer;
    public List<string> targetTags;

    public Camera renderTextureCamera;
    public RenderTexture renderTexture;

    private void Update()
    {
        // Convert mouse position to render texture space
        Vector2 mousePos = Input.mousePosition;
        Vector2 renderTextureMousePos = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);

        // Cast a ray from the render texture camera through the converted mouse position
        Ray renderTextureRay = renderTextureCamera.ViewportPointToRay(renderTextureMousePos);
        RaycastHit hit;

        // Raycast in render texture space
        if (Physics.Raycast(renderTextureRay, out hit, Mathf.Infinity, targetLayer))
        {
            // Object hit, handle hover logic here
            Debug.Log("Mouse is hovering over: " + hit.collider.gameObject.name);
        }
        else
        {
            // No object hit, handle hover exit logic here
            Debug.Log("Mouse is not hovering over any object.");
        }
    }
}
