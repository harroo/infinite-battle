
using UnityEngine;

public class InstantiateWith : MonoBehaviour {

    public GameObject[] objectList;

    private void Start () {

        foreach (var go in objectList)
            Instantiate(go, transform.position, transform.rotation);

        Destroy(this);
    }
}
