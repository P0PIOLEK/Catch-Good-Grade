using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymetryXPosition : MonoBehaviour
{

    public GameObject hero;

    Vector3 currentPosition;
    Vector3 targetPosition;

    float StartTime;
    private float currentTime;
    public float RandomYMax;
    public float RandomXMin;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SetNewPosition", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime =  Time.time - StartTime;
        transform.position = Vector3.Slerp(currentPosition, targetPosition, currentTime);

    }

    void SetNewPosition()
    {
        currentPosition = transform.position;
        targetPosition = new Vector3(Mathf.Abs(hero.transform.position.x), Random.Range(RandomXMin, RandomYMax), transform.position.z);
        StartTime = Time.time;
    }

}
