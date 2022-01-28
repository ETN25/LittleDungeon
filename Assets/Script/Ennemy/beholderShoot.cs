using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne
public class beholderShoot : MonoBehaviour
{
    public GameObject bullet;
    public LayerMask Player;

    public float speed, spread, CooldDown;
    public bool PlayerInSightRange;

    private void Update()
    {
        PlayerInSightRange = Physics.CheckSphere(transform.position, 25f, Player);

        if (PlayerInSightRange)
        {
            CooldDown += 1 * Time.deltaTime;

            if (CooldDown > 3)
            {
                Vector3 Position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                Instantiate(bullet, Position, transform.rotation);
                CooldDown = 0;
            }

        }

    }

}
