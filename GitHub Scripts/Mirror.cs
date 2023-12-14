using UnityEngine;

public class Mirror : MonoBehaviour
{
    public Camera sourceCamera;

    private Material mirrorMaterial;

    void Start()
    {
        // Check if a source camera is assigned
        if (sourceCamera == null)
        {
            Debug.LogError("Mirror script requires a source camera. Please assign a camera in the inspector.");
            return;
        }

        // Create or use existing material
        if (GetComponent<Renderer>().material == null)
        {
            mirrorMaterial = new Material(Shader.Find("Standard"));
            GetComponent<Renderer>().material = mirrorMaterial;
        }
        else
        {
            mirrorMaterial = GetComponent<Renderer>().material;
        }

        // Apply the source camera's texture to the material
        mirrorMaterial.mainTexture = sourceCamera.targetTexture;
    }
}
