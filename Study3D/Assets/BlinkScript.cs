using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    void OnEnable()
    {
        transform.position = new Vector3(Random.Range(0, 10f), 0f, Random.Range(0, 10f));
    }

    void Update()
    {
        transform.position += new Vector3(1f * Time.deltaTime, 0, 1f * Time.deltaTime);
    }
}
