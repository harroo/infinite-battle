
using UnityEngine;

public class PrintController : MonoBehaviour {

    private bool printNext, printing;

    private void Update () {

        if (printing) {

            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                -9.0f
            );

            printNext = false;
            printing = false;
        }

        if (printNext && !printing) {

            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                -7.0f
            );

            printing = true;
        }
    }

    public void Print () {

        printNext = true;
    }

    public bool isPrinting => printNext || printing;
}
