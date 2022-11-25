using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStars : MonoBehaviour
{
    private void Awake()
    {
        StartGenerateStars();
    }

    void Start()
    {
        
    }

    void Update()
    {
    
    }

    int GenerateRandomNumber()
    {
        return Random.Range(0, 4);
    }

    void StartGenerateStars()
    {
        int randomIndex = GenerateRandomNumber();
        if(randomIndex == 0)
        {
            return;
        }
        else
        {
            for (int i = 0; i < GenerateRandomNumber(); i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }   
    }
}
