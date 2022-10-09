using System.Collections;
using UnityEngine;
using TMPro;

public class FadeInText : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    public float duration;
    public void Start()
    {
        StartCoroutine(FadeIn());
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {
        //float duration = 2f; //Fade out over 2 seconds.
        float currentTime = 0f;
        while (currentTime < duration)
        {
            float alpha = Mathf.Lerp(0f, 1f, currentTime / duration); // Switch 0 and 1 to create a fadeout
            textDisplay.color = new Color(textDisplay.color.r, textDisplay.color.g, textDisplay.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield break;
    }

    private IEnumerator FadeOut()
    {
        //float duration = 2f; //Fade out over 2 seconds.
        float currentTime = 0f;
        while (currentTime < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, currentTime / duration); // Switch 0 and 1 to create a fadeout
            textDisplay.color = new Color(textDisplay.color.r, textDisplay.color.g, textDisplay.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield break;
    }
}
