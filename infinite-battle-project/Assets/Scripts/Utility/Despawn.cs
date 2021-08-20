
using UnityEngine;

public class Despawn : MonoBehaviour {

    public float aliveTime;

    private void Update () {

        aliveTime -= Time.deltaTime;

        if (aliveTime < 0)
            Destroy(gameObject);
    }
}
