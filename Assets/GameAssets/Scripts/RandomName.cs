using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomName : MonoBehaviour
{
    public List<string> Names = new List<string>();
    public Button RandomNameButton;
    public TextMeshProUGUI NameText;

    private void Start()
    {
        RandomNameButton.onClick.AddListener(GetRandomName);
    }

    private void GetRandomName()
    {
        if (Names.Count == 0) return;
        int randomIndex = 0;
        randomIndex = Random.Range(0, Names.Count - 1);
        NameText.SetText(Names[randomIndex]);
        Names.RemoveAt(randomIndex);

    }
}
