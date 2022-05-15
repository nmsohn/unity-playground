using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        var rotationSpeed = 60 * Time.deltaTime;
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
    }
}
