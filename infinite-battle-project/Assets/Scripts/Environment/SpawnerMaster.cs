
using UnityEngine;

public class SpawnerMaster : MonoBehaviour {

    public GameObject prefab;
    private GameObject cache;

    private void Start () {

        transform.position = new Vector3(
            Random.Range(-30.0f, 30.0f), Random.Range(-30.0f, 30.0f), -9.0f
        );
    }

    private void Update () {

        if (cache == null)
            cache = Instantiate(prefab, transform.position, transform.rotation);
    }
}
