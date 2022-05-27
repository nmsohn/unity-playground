using UnityEngine;

namespace Assets
{
    public class Calc : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Sum(1, 1));
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}