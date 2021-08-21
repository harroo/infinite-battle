
using UnityEngine;

public class PrintAndDestroy : MonoBehaviour {

    private PrintController printController;

    private void Start () {

        printController = GetComponent<PrintController>();

        printController.Print();
    }

    private void Update () {

        if (printController.isPrinting) return;

        Destroy(gameObject);
    }
}
