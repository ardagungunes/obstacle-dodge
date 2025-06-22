using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    int playerScore = 0;
    [SerializeField] Material material;
    Color color = new Color(0.2196078f, 0.2196078f, 0.2196078f, 1f);
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    /// <summary>
    /// Handles collision events. Increments player score if the collided object's material color
    /// is different from the specified color and the object is not tagged as "Floor".
    /// </summary>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MeshRenderer>().materials[0].color != color && !collision.gameObject.CompareTag("Floor"))
        {
            Debug.Log(collision.gameObject.GetComponent<MeshRenderer>().material);
            playerScore++;
            Debug.Log("Player Score: " + playerScore);
        }


    }
}
