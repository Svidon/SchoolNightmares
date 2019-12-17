using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreedyIllusionCoinController : MonoBehaviour
{
    private float lifeTime = 6f;

    void Start(){
        lifeTime = 6f;
    }

    void Update(){
        if (lifeTime <= 0){
            Destroy(gameObject);
        } else {
            lifeTime -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {

        // Checks if it's the bully that hit the coin
        if (other.CompareTag("Bully")) {
            other.gameObject.GetComponent<BullyController>().Stunned();
        }
    }
}
