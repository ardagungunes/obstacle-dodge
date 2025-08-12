using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    [SerializeField] Vector3 rotationVector = new Vector3(0f, 0f, 0f);
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(rotationVector,Space.Self);
    }
}
