using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 playerPosition;
    Vector3 direction;
    [SerializeField] float projectileSpeed = 1.1f;
    void Start()
    {
        playerPosition = player.transform.position;
        direction = (playerPosition - transform.position).normalized;
        Debug.Log("Direction: " + direction);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * projectileSpeed * Time.deltaTime;
        DestroyProjectile();

    }

    

    void DestroyProjectile()
    {
        if(Vector3.Distance(transform.position, playerPosition) <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
