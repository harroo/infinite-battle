
using UnityEngine;

public class PrintAtInterval : MonoBehaviour {

    public float interval;
    private float timer;

    private PrintController printController;

    private void Start () {

        printController = GetComponent<PrintController>();
    }

    private void Update () {

        if (timer < 0) { timer = interval;

            printController.Print();

        } else timer -= Time.deltaTime;
    }
}
