using UnityEngine;

public class DropperObjectsLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    MeshRenderer meshRenderer;
    float dropTime = 3f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > dropTime)
        {
            rb.useGravity=true;
            meshRenderer.enabled = true;
            dropTime = 0f;
        }
    }
}
