using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    [SerializeField]private GameObject blackHoleText;
    [SerializeField]private GameObject skeeBallText;
    [SerializeField]private ParticleSystem particleSystem;
    [SerializeField] private float textFadeOutSB;
    public float textFadeOutBH;
    public bool isTextActive = true;
    void Start()
    {
        StartCoroutine(DisableSBText());
        StartCoroutine(DisableBHText());
        // StartCoroutine(PlayPS());
    }

    IEnumerator DisableSBText()
    {
        yield return new WaitForSeconds(textFadeOutSB);
        skeeBallText.SetActive(false);
    }
    IEnumerator DisableBHText()
    {
        yield return new WaitForSeconds(textFadeOutBH);
        particleSystem.Play();
        blackHoleText.SetActive(false);
    }
    IEnumerator PlayPS()
    {
        yield return new WaitForSeconds(textFadeOutBH - 0.3f);
        particleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}