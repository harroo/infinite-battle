
using UnityEngine;

public class SimpleTankCommander : MonoBehaviour {

    public float moveSpeed, turnSpeed, turretSpeed;
    public Transform turret, bulletSpawn;
    public GameObject bulletPrefab;

    private float timer;
    private int actionId;

    private void Update () {

        if (timer < 0) { timer = Random.Range(0.0f, 8.0f);

            Think();

        } else { timer -= Time.deltaTime;

            Act();
        }
    }

    private void Think () {

        actionId = Random.Range(0, 6);
    }

    private void Act () {

        switch (actionId) {

            case 0: transform.Translate(Vector3.up * moveSpeed * Time.deltaTime); break;
            case 1: transform.Translate(Vector3.down * moveSpeed * Time.deltaTime); break;

            case 2: transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime); break;
            case 3: transform.Rotate(Vector3.back * turnSpeed * Time.deltaTime); break;

            case 4: turret.Rotate(Vector3.forward * turretSpeed * Time.deltaTime); break;
            case 5: turret.Rotate(Vector3.back * turretSpeed * Time.deltaTime); break;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.forward);

        if (hit.collider != null) {

            if (hit.collider.tag == "TANK") {

                Fire();
            }
        }
    }

    private void Fire () {

        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }
}
