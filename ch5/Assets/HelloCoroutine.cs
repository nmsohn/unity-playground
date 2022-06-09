using System.Collections;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("HelloUnity");
        StartCoroutine("HiCSharp");
        Debug.Log("End");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StopCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity()
    {
        // Debug.Log("Hello");
        //
        // yield return new WaitForSeconds(3f);
        //
        // Debug.Log("Unity");
        while (true)
        {
            yield return null; //1/60초 = 1 프레임을 쉬게 된다
            Debug.Log("Hello Unity");
        }
    }

    IEnumerator HiCSharp()
    {
        Debug.Log("Hi");

        yield return new WaitForSeconds(5f);
        
        Debug.Log("CSharp");
    }

}
