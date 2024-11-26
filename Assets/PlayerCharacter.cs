using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = 10000;
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        //if (_health <= 0)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //    Debug.Log("End");
        //}
        Debug.Log("Health: " + _health);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
