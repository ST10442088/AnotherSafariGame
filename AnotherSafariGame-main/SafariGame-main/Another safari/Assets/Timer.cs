using UnityEngine;
using TMPro;
using System.Threading;
public class Timer : MonoBehaviour
{

    float beginningTime = 50;
    [SerializeField] TextMeshProUGUI timeRemainingText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountdownTimer();
    }

    void CountdownTimer()
    {
        beginningTime = beginningTime - Time.deltaTime;
        timeRemainingText.text = "Time remaining: " + beginningTime;
        if (beginningTime <= 0)
        {
            beginningTime = 50;
        }
    }
}
