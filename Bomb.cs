using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {


    public GameObject explosionPrefab;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(explosionPrefab,
                        this.transform.position,
                        this.transform.rotation);
            
        }
        
    }
}
