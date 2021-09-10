using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MERMİ : MonoBehaviour
{
    public GameObject Zombi;
    void OnCollisionEnter(Collision col)
    {
        string Objeisim = col.gameObject.name;
        if (Objeisim.Equals("Zombie_01"))
        {
            Destroy(Zombi, 0.4f);

        }
    }
}
