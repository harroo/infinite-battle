
using UnityEngine;

public class WatchAndCreate : MonoBehaviour {

    public GameObject prefab;
    private GameObject cache;

    private void Update () {

        if (cache == null)
            cache = Instantiate(prefab, transform.position, transform.rotation);
    }
}
