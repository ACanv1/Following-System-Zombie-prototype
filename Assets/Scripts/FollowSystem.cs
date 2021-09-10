using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowSystem : MonoBehaviour
{
    private GameObject oyuncu;
    private GameObject Zombi;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.Find("FPSController");
        Zombi = GameObject.Find("Zombie_01");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
        
    }
}
