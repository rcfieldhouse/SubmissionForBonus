using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public static CharacterHealth instance;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3.0f;
      
    }
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage()
    {
        health--;
        if (health >= 0)
        {
            //lose condition
            Destroy(gameObject);
        }
    }
}
