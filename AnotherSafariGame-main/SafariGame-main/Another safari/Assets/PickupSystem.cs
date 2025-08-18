using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickupSystem : MonoBehaviour
{
    
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

    }
    
  /*  private void BoxReAppearance()
    {
        this.gameObject.SetActive(true);

    }  */
}
