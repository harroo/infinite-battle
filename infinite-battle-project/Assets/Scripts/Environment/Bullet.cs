
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float force;

    private void Start () {

        GetComponent<Rigidbody2D>().AddForce(transform.up * force);
    }
}
