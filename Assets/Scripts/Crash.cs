using UnityEngine;

public class Crash : MonoBehaviour
{

    MeshRenderer meshRenderer;
    [SerializeField] Material material;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material = material;

    }
}
