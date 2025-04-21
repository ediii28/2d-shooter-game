using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject ProjectilePreFab;
    [SerializeField] private Transform ShootingPoint;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject pr = Instantiate (ProjectilePreFab , ShootingPoint.position , Quaternion.identity);
            pr.GetComponent<PlayerProjectile>().SetDirection(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

}

