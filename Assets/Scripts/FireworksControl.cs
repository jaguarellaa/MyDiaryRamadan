using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksControl : MonoBehaviour
{
    [SerializeField] GameObject firework;
    [SerializeField] GameObject button;
    [SerializeField] GameObject buttonHand;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject havan;
    Animation anim;

    public AudioSource[] sounds;

    public void Start()
    {
        anim = havan.GetComponent<Animation>();
        anim.Stop("havanAnim");
        sounds[1].Play();
    }

    
    public void Fireworks()
    {

        sounds[0].Play();
        buttonHand.SetActive(false);
        ball.SetActive(true);
        anim.Play("havanAnim");
        firework.SetActive(true);
        StartCoroutine(Ball());
        StartCoroutine(Ramazan());
        button.SetActive(false);
    
        sounds[2].Play();

    }
    IEnumerator Ball()
    {
        yield return new WaitForSeconds(0.7f);
        ball.SetActive(false);

    }
    IEnumerator Ramazan()
    {
        yield return new WaitForSeconds(0.5f);
    }
    public void FireworksReset()
    {
        buttonHand.SetActive(true);
        firework.SetActive(false);
        ball.SetActive(false);
        button.SetActive(true);
        Start();
    }

 
}
