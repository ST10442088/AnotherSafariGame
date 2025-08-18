using UnityEngine;

public class FirstAidSystem : MonoBehaviour
{
    int firstAidCounter = 1;
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
           FirstAidCounter.currentInstance.CountFirstAid(firstAidCounter); 
        
    }
}
