using UnityEngine;

public class DropperObjectsLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    float dropTime = 3f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > dropTime)
        {
            rb.useGravity=true;
            dropTime = 0f;
        }
    }
}
