using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    // Optional: assign color from inspector
    public Color newColor = Color.red;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            // Change the color
            spriteRenderer.color = newColor;
        }
        else
        {
            Debug.LogWarning("No SpriteRenderer found on this GameObject!");
        }
    }
}
