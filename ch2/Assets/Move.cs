using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 move = new(-5, 5, -5);

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Relocate();
        }
    }

    void Relocate()
    {
        transform.Translate(move * Time.deltaTime, Space.World);
    }
}
