using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int score = 0;
    private static ScoreManager instance;

    public static ScoreManager GetInstance()
    {
        if (instance is null)
        {
            instance = FindObjectOfType<ScoreManager>();

            if (instance is null)
            {
                GameObject container = new GameObject("ScoreManager");

                container.AddComponent<ScoreManager>();
            }
        }
        
        return instance;
    }
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (instance is not null)
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    
    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;
    }
}
