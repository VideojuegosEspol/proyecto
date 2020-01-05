using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // Rigth here begin functionality to controling health bar
    public RectTransform rectTransform;
    public static float Heath { get; set; }

    void Start()
    {
        Heath = 100f;
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float UpdateLife = Mathf.MoveTowards(RectTransform.rect.height, Heath, 5.0f);

        rectTransform.sizeDelta = new Vector2(100f, Mathf.Clamp(UpdateLife, 0.0f, 100f));
    }
}
