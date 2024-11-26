using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingPopup settings_popup;
    // Start is called before the first frame update
    //private int _score;
    void Start()
    {
        settings_popup.Close();
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }
    public void OnOpenSettings()
    {
        settings_popup.Open();
    }
    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
}
