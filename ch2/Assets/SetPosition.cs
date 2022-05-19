using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //global 포지션 수정
        // transform.position = new Vector3(0, 0, 0);
        //local 포지션 수정
        transform.localPosition = new Vector3(0, 0, 0);
        
        //부모와 상관 없이 global 위치
        // transform.lossyScale
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
