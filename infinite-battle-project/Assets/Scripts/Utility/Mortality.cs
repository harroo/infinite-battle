
using System;

using UnityEngine;

public class Mortality : MonoBehaviour {

    public bool everythingHurts;

    public string[] harmfulTags;

    public int hitPoints;

    public GameObject instantiateOnDie, instantiateOnHit;

    private void OnCollisionEnter2D (Collision2D collision2D) {

        if (Array.IndexOf(harmfulTags, collision2D.collider.tag) > -1 || everythingHurts) {

            hitPoints--;

            if (instantiateOnHit != null)
                Instantiate(instantiateOnHit, transform.position, transform.rotation);

            if (hitPoints <= 0) {

                if (instantiateOnDie != null)
                    Instantiate(instantiateOnDie, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
    }
}
