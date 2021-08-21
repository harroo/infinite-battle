
using UnityEngine;

public class InstantiateOnDestroy : MonoBehaviour {

    public GameObject[] objectList;

    private void OnDestroy () {

        foreach (var go in objectList)
            Instantiate(go, transform.position, transform.rotation);
    }
}
