using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntHP : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = updater.antHp;
        fill.color = gradient.Evaluate(slider.value);
        UpdateHealth(slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        float harm = updater.antHp;
        UpdateHealth(harm);
    }

    public void UpdateHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.value);

    }
}
