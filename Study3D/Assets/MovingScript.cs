using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position += new Vector3(0.1f, 0, 0.1f);

        float distance = Vector3.Distance(transform.position, Vector3.zero);

        Debug.Log($"°Å¸®´Â : {distance}");
    }
}
