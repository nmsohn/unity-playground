using UnityEngine;

public class SetRotation : MonoBehaviour
{
    public Transform targetTransform;
    void Start()
    {
        // transform.rotation = Quaternion.Euler(new Vector3(30, 30, 30));
        // Quaternion up = Quaternion.LookRotation(new Vector3(0,1,0));
        // Vector3 direction = targetTransform.position - transform.position;
        // Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        // Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));
        
        //중간값
        //a =0
        //b =1
        // Quaternion targetRotation = Quaternion.Lerp(aRotation, bRotation, 0.5f);
        //
        // transform.rotation = targetRotation;

        // Quaternion targetRotation = Quaternion.Euler(new Vector3(45, 0, 0));
        //
        // transform.rotation = targetRotation;
        // transform.Rotate(new Vector3(30,0,0));
        
    }
}
