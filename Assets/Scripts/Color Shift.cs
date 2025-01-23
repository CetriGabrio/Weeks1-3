using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color originalColor;
    public Color mouseOverColor = Color.red;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void OnMouseEnter()
    {
        spriteRenderer.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        spriteRenderer.color = originalColor;
    }
}
