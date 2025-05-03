<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
>>>>>>> 9cbc6f8b147b62579adc7fad3155dc91c4bda553
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject ProjectilePrefab;
    [SerializeField] private Transform ShootingPoint;

    // 1) Cum detectam controlul de shooting
    // 2) Ce proiectil folosim
    // 3) In ce directie se va duce proiectilul

    private void Update()
    {
        // daca dau click
        // instantiezi proiectilul, si il faci sa se miste spre directia unde am dat click

        if (Input.GetMouseButtonDown(0))
        {
            //                           ce instantiez           pozitia                rotatia
            GameObject pr = Instantiate(ProjectilePrefab, ShootingPoint.position, Quaternion.identity);
            pr.GetComponent<PlayerProjectile>().SetDirection(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
