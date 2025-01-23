using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public GameObject spritePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject newSprite = Instantiate(spritePrefab, mousePosition, Quaternion.identity);

            SpriteRenderer spriteRenderer = newSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.color = Random.ColorHSV();

            float randomSize = Random.Range(0.5f, 1.0f);
            newSprite.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

        }
    }
}

public class Destroyable : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
