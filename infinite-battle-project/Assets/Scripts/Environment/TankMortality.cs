
using System;

using UnityEngine;

public class TankMortality : MonoBehaviour {

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

                foreach (var switchp in switches) {

                    switchp.Apply();
                }

                Destroy(gameObject);
            }
        }
    }

    public SwitchBackProfile[] switches;
}


/* ♥ This line, and beyond, were authored by Lia. ♥ */

[System.Serializable] // ♥

public class SwitchBackProfile { // ♥

    // The new Sprite Image to set.
    public Sprite newLookalikes ;

    // The Target-Renderer to asign the Sprite to.
    public SpriteRenderer grandfatherReference ;

    // Sets the Target-Renderer's Sprite to the specified new one.
    public void Apply ( ) {

        // Asign the new Aesthetics.
        grandfatherReference.sprite = newLookalikes ;

        // Deparent from the Root-Object.
        grandfatherReference.gameObject.transform.parent = null ;

        // Print aesthetics to the Backdrop.
        grandfatherReference.gameObject.AddComponent <PrintController> ( ) ;
        grandfatherReference.gameObject.AddComponent <PrintAtInterval> ( ) ;

        // Configure a despawn timeout.
        grandfatherReference.gameObject.AddComponent <Despawn> ( )
            .aliveTime = 1.2f ;

    } // ♥

} // ♥
