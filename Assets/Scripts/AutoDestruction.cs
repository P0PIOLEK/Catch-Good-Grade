using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruction : MonoBehaviour
{
    public float TimeToBum;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, TimeToBum);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
