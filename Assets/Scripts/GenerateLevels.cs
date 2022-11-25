using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GenerateLevels : MonoBehaviour
{
    [SerializeField] GameObject levelButtonPrefab;
    [SerializeField] Transform parent;
    List<GameObject> levelButtons;

    private void Awake()
    {
        levelButtons = new List<GameObject>();
        StartGenerateButtons();
    }

    void Start()
    {
        
        
    }

    void Update()
    {
        
    }

    GameObject CreateButton(int index)
    {
        GameObject button;
        button = Instantiate(levelButtonPrefab, parent);
        levelButtons.Add(button);
        button.GetComponentInChildren<Transform>().gameObject.GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();
        return button;
    }

    void StartGenerateButtons()
    {
        for (int i = 1 ; i <= 100; i++)
        {
            CreateButton(i);
        }
    }
     
}
