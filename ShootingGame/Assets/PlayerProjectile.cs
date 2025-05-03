using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField] private float Speed = 10f;

    public void SetDirection (Vector3 mousePosition)
    {
        Vector3 direction = (mousePosition - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity= direction * Speed;
    }

    private void Update()
    {
        if(!GetComponent<SpriteRenderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
