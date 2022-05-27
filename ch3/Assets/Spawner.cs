using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject target;

    void Start()
    {
        //RigidBody 해도 똑같이 생성됨
        GameObject instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);

        instance.GetComponent<Rigidbody>().AddForce(0, 1000, 0);
        
        Debug.Log(instance.name);
    }
}