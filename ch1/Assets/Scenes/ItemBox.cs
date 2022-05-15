using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOverlapped = false;
    private Renderer myRenderer;
    public Color triggeredColor;
    private Color originalColor;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    void Update()
    {

    }

    // Enter 충돌을 한 순간
    // Exit 충돌 후 떼어질 때
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverlapped = true;
            myRenderer.material.color = triggeredColor;
            // Debug.Log("트리거인 콜라이더와 충돌");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverlapped = false;
            myRenderer.material.color = originalColor;
        }
    }
    // 충돌하고 붙어 있는 동안
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverlapped = true;
            myRenderer.material.color = triggeredColor;
        }
    }

    // void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log("일반 콜라이더와 충돌");
    // }
}
