using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThirdPersonPosition();
        ThirdPersonRotation();
    }

    void ThirdPersonPosition()
    {
        float x = (xOffset) * Mathf.Sin(target.rotation.y);
        float z = (xOffset) * Mathf.Cos(target.rotation.y);

        transform.position = new Vector3(x, yOffset, z) + target.position;
    }

    void ThirdPersonRotation()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, target.rotation.eulerAngles.y, transform.rotation.z);
    }
}
