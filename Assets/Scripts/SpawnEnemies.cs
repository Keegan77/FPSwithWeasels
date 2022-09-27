using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    private int timerStart = 3;
    private float timer = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(enemy, gameObject.transform);
            timer = timerStart;
        }
        Debug.Log(timer);

    }
}
