using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    public List<Color> colors = new List<Color>()
    {
        Color.green,
        Color.blue,
        Color.yellow,
    };
    

    // Optional: assign color from inspector
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Color randomColor = colors[Random.Range(0, colors.Count)];
        spriteRenderer.color = randomColor;
    }
}
