using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class SettingPopup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider slider;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("speed", 1);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false); 
    }
    void Update()
    { 

    }

}
