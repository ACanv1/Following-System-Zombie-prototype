using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tımeofthemoonandsun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(-1.94f, 0, -1.94f), Vector3.right, 10f * Time.deltaTime);
    }
}
