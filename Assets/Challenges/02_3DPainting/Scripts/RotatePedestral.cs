using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RotatePedestral : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI text;
    private void Awake()
    {
        slider.onValueChanged.AddListener(delegate { Rotate(); });
    }
    public void Rotate()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, slider.value, 0);
        text.text = $"GO: {gameObject.transform.rotation.y}";
    }
}
