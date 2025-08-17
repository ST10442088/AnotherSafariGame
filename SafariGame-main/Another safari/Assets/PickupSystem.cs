using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickupSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int waitForSeconds = 3;
    int scoreIncrement = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         this.gameObject.SetActive(false);
        ScoreTracker.currentInstance.AddScore(scoreIncrement);

        Invoke("BoxReAppearance", waitForSeconds);
    }
    
    private void BoxReAppearance()
    {
        this.gameObject.SetActive(true);

    }
}
