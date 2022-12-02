using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float speed;
    Vector3 StartPosistion;
    

    private void Start()
    {
        StartPosistion = transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
       if(transform.position.y > 16f)
        {
            transform.position = StartPosistion;
        }
    }
}
