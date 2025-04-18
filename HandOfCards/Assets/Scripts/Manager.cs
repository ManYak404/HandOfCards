using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject cardPrefab;         // card prefab
    public float radius = 0.5f;           // Radius of the fan arc
    public float maxArcDegrees = 60f;     // Total arc span (e.g. -30° to +30°)
    public Vector2 handCenter = Vector2.zero; // Center of the hand in world space
    
    private List<GameObject> cards = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Press space to draw a card
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        GameObject newCard = Instantiate(cardPrefab, transform);
        cards.Add(newCard);
        UpdateFanLayout();
    }

    void UpdateFanLayout()
    {
        int count = cards.Count;
        float angleStep = 0f;

        if (count > 1)
            angleStep = maxArcDegrees / (count - 1);

        float startAngle = -(angleStep * count);

        for (int i = 0; i < count; i++)
        {
            float angle = startAngle + (angleStep * i);
            float rad = Mathf.Deg2Rad * angle;

            // Polar to Cartesian, offset from hand center
            float x = Mathf.Sin(rad) + handCenter.x;
            float y = Mathf.Cos(rad) + handCenter.y;

            Transform card = cards[i].transform;
            card.position = new Vector3(x, y, 0);
            card.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
