
using System;

using UnityEngine;

public class Mortality : MonoBehaviour {

    public string[] harmfulTags;

    public int hitPoints;

    public GameObject instantiateOnDie, instantiateOnHit;

    private void OnCollisionEnter2D (Collision2D collision2D) {

        if (Array.IndexOf(harmfulTags, collision2D.collider.tag) > -1) {

            hitPoints--;

            Instantiate(instantiateOnHit, transform.position, transform.rotation);

            if (hitPoints < 0) {

                Instantiate(instantiateOnDie, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
    }
}
