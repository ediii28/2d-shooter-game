using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private Transform player;        // The target (player)
    public float chaseSpeed = 3f;
    public float orbitSpeed = 120f; // degrees per second
    public float orbitRadius = 2f;
    public float orbitExitBuffer = 0.5f; // how far beyond orbitRadius it can go before chasing again

    private float currentAngle = 0f;
    
    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        // If too far from player, chase
        if (distance > orbitRadius + orbitExitBuffer)
        {
            MoveTowardsPlayer();
        }
        // If within orbit range, orbit
        else if (distance <= orbitRadius)
        {
            OrbitPlayer();
        }
        // If in buffer zone between radius and radius+buffer, hold position
        else
        {
            // Smooth transition (optional) or do nothing
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position += (Vector3)(direction * chaseSpeed * Time.deltaTime);

        // Update angle so when orbit starts, it's smooth
        Vector2 offset = (Vector2)(transform.position - player.position);
        currentAngle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
    }

    void OrbitPlayer()
    {
        currentAngle += orbitSpeed * Time.deltaTime;
        float radians = currentAngle * Mathf.Deg2Rad;
        Vector2 offset = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians)) * orbitRadius;
        transform.position = player.position + (Vector3)offset;
    }
}
