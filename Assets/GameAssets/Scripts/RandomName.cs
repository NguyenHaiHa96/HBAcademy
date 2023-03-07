using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomName : MonoBehaviour
{
    public ParticleSystem FX;
    public List<string> Names = new List<string>();
    public Button RandomNameButton;
    public TextMeshProUGUI NameText;
    public float TimeGetName = 0.2f;
    public float DelayTime;
    public float DelayFX = 0.4f;

    private void Start()
    {
        RandomNameButton.onClick.AddListener(GetRandomName);
        Helper.ButtonOnClickTween(RandomNameButton);    
    }

    private void GetRandomName()
    {
        if (Names.Count == 0) return;
        int randomIndex = 0;
        randomIndex = Random.Range(0, Names.Count - 1);
        StartCoroutine(DelayGetRandomName(randomIndex)); 
    }

    private IEnumerator DelayGetRandomName(int index)
    {
        int randomIndex = 0;
        for (int i = 0; i < 10; ++i)
        {
            randomIndex = Random.Range(0, Names.Count - 1);
            NameText.SetText(Names[randomIndex]);
            yield return Helper.GetWaitForSeconds(TimeGetName);
        }
        yield return new WaitForEndOfFrame();
        NameText.SetText(Names[index]);
        Names.RemoveAt(index);
        yield return Helper.GetWaitForSeconds(DelayFX);
        FX.Play();
    }
}
