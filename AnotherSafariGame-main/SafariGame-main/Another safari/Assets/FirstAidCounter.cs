using UnityEngine;
using TMPro;

public class FirstAidCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI firstAidText;
   public int initialFirst_AidCount = 0;
    int firstAidCountIncrement = 1;
    public static FirstAidCounter currentInstance;
   
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
     
    public void CountFirstAid(int firstAidAmountIncrement)
    {
        firstAidAmountIncrement = this.firstAidCountIncrement;
        initialFirst_AidCount = initialFirst_AidCount + firstAidAmountIncrement;
        firstAidText.text = "First Aid Kits: " + initialFirst_AidCount;
    }
    
  
}
