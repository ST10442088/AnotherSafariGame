using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class ScoreTracker : MonoBehaviour
{
   

    [SerializeField] TextMeshProUGUI scoreText;

    int scoreIncrement = 5;
    int startScore = 0;
    public static ScoreTracker currentInstance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void Awake()
    {
        if (currentInstance == null)
        {
            currentInstance = this;
        }

        else
        {
            Destroy(currentInstance);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int scoreIncrement)
    {
        scoreIncrement = this.scoreIncrement;
        startScore = startScore + scoreIncrement;
        scoreText.text = "Score: " + startScore;

    }
}
