using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
   
    private GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] enemies = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null)
        {
            for (int i = 0; i < 2; i++)
            {
                _enemy = Instantiate(enemyPrefab) as GameObject;
                _enemy.transform.position = new Vector3(0, 1, 0);
                float angle = Random.Range(0, 360);
                _enemy.transform.Rotate(0, angle, 0);
            }
        }
    }
}
