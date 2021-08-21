
using UnityEngine;

public class SimpleTankCommander : MonoBehaviour {

    public float moveSpeed, turnSpeed, turretSpeed, fireDelay;
    public Transform turret, bulletSpawn;
    public GameObject bulletPrefab;

    private float timer, fireTimer;
    private int actionId;

    private void Update () {

        if (timer < 0) { timer = Random.Range(0.0f, 8.0f);

            Think();

        } else { timer -= Time.deltaTime;

            Act();
        }

        fireTimer -= Time.deltaTime;
    }

    private void Think () {

        actionId = Random.Range(0, 10);
    }

    private void Act () {

        switch (actionId) {

            //go forward or back
            case 0: transform.Translate(Vector3.up * moveSpeed * Time.deltaTime); break;
            case 1: transform.Translate(Vector3.down * moveSpeed * Time.deltaTime); break;

            //pivot left or right
            case 2: transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime); break;
            case 3: transform.Rotate(Vector3.back * turnSpeed * Time.deltaTime); break;

            //move turret left or right
            case 4: turret.Rotate(Vector3.forward * turretSpeed * Time.deltaTime); break;
            case 5: turret.Rotate(Vector3.back * turretSpeed * Time.deltaTime); break;
        }

        RaycastHit2D hit = Physics2D.Raycast(bulletSpawn.position, turret.up);

        if (hit.collider != null) {

            if (hit.collider.tag == "TANK") {

                Fire();
            }
        }
    }

    private void Fire () {

        if (fireTimer < 0) fireTimer = fireDelay; else return;

        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }
}
