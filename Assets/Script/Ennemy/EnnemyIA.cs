using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FAIT PAR ETIENNE QUI A DECOUVERT A LA FIN QU'IL AURAIT PU FAIRE PLUS SIMPLE
public class EnnemyIA : MonoBehaviour
{
    public Transform player;
    public LayerMask Ground, Player;
    public Vector3 Walkpoint;
    bool Walkpointset;
    public float walkPointRange, SightRange, ChaseRange, eyesHeight;
    public bool PlayerInSightRange, spotted, PlayerInChaseRange;
    public float speed;
    public float X, Z, Vx, Vz;
    public bool lockRotation;

    // Start is calle;d before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; ;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerInSightRange = Physics.CheckSphere(transform.position, SightRange, Player);
        PlayerInChaseRange = Physics.CheckSphere(transform.position, ChaseRange, Player);

        RaycastHit Hit;
        X = player.position.x;
        Z = player.position.z;
        Vx = X - transform.position.x;
        Vz = Z - transform.position.z;
        float Head = player.position.y + 1.8f;
        Vector3 PlayerDirection = new Vector3(Vx,Head - eyesHeight, Vz);
        float DistanceJoueur = Vector3.Distance(player.position, transform.position);
        Vector3 Regard = new Vector3(transform.position.x, transform.position.y + eyesHeight, transform.position.z);

        Debug.DrawRay(Regard, PlayerDirection, Color.red);
        if (Physics.Raycast(Regard, PlayerDirection, out Hit, DistanceJoueur)) 
        {
            var selection = Hit.transform;
            //Debug.Log("touché un truc !");
            if (selection.CompareTag("Wall"))
            {
                if (spotted)
                {
                    float randomZ = Random.Range(-walkPointRange, walkPointRange);
                    float randomX = Random.Range(-walkPointRange, walkPointRange);

                    Walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
                    Debug.Log("perdu de vu");
                    spotted = false;
                }

                Patroling();
                //Debug.Log("touché un mur !");
            }
            else
            {
                /*
                if (spotted)
                {
                    if (PlayerInChaseRange) ChasePlayer();
                    if (!PlayerInChaseRange) Patroling();
                }
                else
                {
                    if (PlayerInSightRange) ChasePlayer();
                    if (!PlayerInSightRange) Patroling();
                }
                */
                if (PlayerInSightRange) ChasePlayer();
                if (!PlayerInSightRange) Patroling();

            }
        }
        else
        {
            /*
                 if (spotted)
                 {
                     if (PlayerInChaseRange) ChasePlayer();
                     if (!PlayerInChaseRange) Patroling();
                 }
                 else
                 {
                     if (PlayerInSightRange) ChasePlayer();
                     if (!PlayerInSightRange) Patroling();
                 }
                 */
            if (PlayerInSightRange) ChasePlayer();
            if (!PlayerInSightRange) Patroling();
        }
        

    }

    private void Patroling()
    {
        spotted = false;
        
        if (!Walkpointset) SearchWalkpoint();

        if (Walkpointset)
        {
            X = Walkpoint.x;
            Z = Walkpoint.z;
            Vx = X - transform.position.x;
            Vz = Z - transform.position.z;
            transform.position += new Vector3(Vx, 0, Vz).normalized * Time.deltaTime * (speed/2);
            Walkpoint.y = transform.position.y;
        }

        Vector3 distanceToWalkPoint = transform.position - Walkpoint;

        if (distanceToWalkPoint.magnitude < 1f)
        {
            Walkpointset = false;
        }

        //transform.LookAt(Walkpoint);
        Vector3 walkPos = (Walkpoint + new Vector3(0, 0, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(walkPos);
        Quaternion current = transform.localRotation;
        transform.localRotation = Quaternion.Lerp(current, rotation, 10 * Time.deltaTime);

    }

    private void SearchWalkpoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        Walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(Walkpoint, -transform.up, Ground))
        {
            Walkpointset = true;
        }
    }

    private void ChasePlayer()
    {
        spotted = true;
        X = player.position.x;
        Z = player.position.z;
        Vx = X - transform.position.x;
        Vz = Z - transform.position.z;
        transform.position += new Vector3(Vx, 0, Vz).normalized * Time.deltaTime * speed;

        //transform.LookAt(player);

        Vector3 playerPos = (player.position + new Vector3 (0, 0, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(playerPos);
        if(lockRotation)
        {
            rotation.x = 0;
            rotation.z = 0;
        }

        Quaternion current = transform.localRotation;
        transform.localRotation = Quaternion.Lerp(current, rotation, 10 * Time.deltaTime);
    }

}
