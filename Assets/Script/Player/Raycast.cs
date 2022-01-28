using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne, achevez le

public class Raycast : MonoBehaviour
{
    Vector3 rayOrigin = new Vector3(960f, 540f, 0f);
    float rayLeght = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rayOrigin = new Vector3(Screen.width / 2, Screen.height / 2, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {
        Debug.Log("Attaque !");
        Ray ray = Camera.main.ScreenPointToRay(rayOrigin);
        RaycastHit Hit;
        if (Physics.Raycast(ray, out Hit, rayLeght))
        {
            var selection = Hit.transform;
            if (selection.CompareTag("Ennemy"))
            {
                selection.GetComponent<EnnemyVie>().Degats();
            }
        }
    }
}
