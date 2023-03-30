using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionControlBalloon2 : MonoBehaviour
{
    private static GameObject scoreText;
    public static int score;
    public static TextMeshProUGUI scoretext;
    public GameObject[] patlamaPrefab;
    public AudioSource[] popping;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BalloonOrange")
        {
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            scoreText = GameObject.FindWithTag("ScoreText");
            scoretext = scoreText.GetComponent<TextMeshProUGUI>();
            score++;
            scoretext.text = score.ToString();
            Debug.Log(score);

            Canvas canvas = GetComponentInParent<Canvas>();

            for (int i = 0; i < patlamaPrefab.Length; i++)
            {
                GameObject patlamaObjesi = Instantiate(patlamaPrefab[0], transform.position, Quaternion.identity);
                patlamaObjesi.transform.localScale = canvas.transform.localScale + new Vector3(0.01f, 0.01f, 0.01f);
                patlamaObjesi.transform.SetParent(transform.parent);
                Rigidbody rb = patlamaObjesi.GetComponent<Rigidbody>();
                rb.velocity = Vector3.down * 100f;
                Destroy(patlamaObjesi, 1.0f);
            }
        }
        if (collision.gameObject.tag == "Balloon-Blue")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);           
            Canvas canvas = GetComponentInParent<Canvas>();

            for (int i = 0; i < patlamaPrefab.Length; i++)
            {
                GameObject patlamaObjesi = Instantiate(patlamaPrefab[1], transform.position, Quaternion.identity);
                patlamaObjesi.transform.localScale = canvas.transform.localScale + new Vector3(0.01f, 0.01f, 0.01f);
                patlamaObjesi.transform.SetParent(transform.parent);
                Rigidbody rb = patlamaObjesi.GetComponent<Rigidbody>();
                rb.velocity = Vector3.down * 100f;
                Destroy(patlamaObjesi, 1.0f);
            }

        }
        if (collision.gameObject.tag == "Balloon-Green")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);         
            Canvas canvas = GetComponentInParent<Canvas>();

            for (int i = 0; i < patlamaPrefab.Length; i++)
            {
                GameObject patlamaObjesi = Instantiate(patlamaPrefab[2], transform.position, Quaternion.identity);
                patlamaObjesi.transform.localScale = canvas.transform.localScale + new Vector3(0.01f, 0.01f, 0.01f);
                patlamaObjesi.transform.SetParent(transform.parent);
                Rigidbody rb = patlamaObjesi.GetComponent<Rigidbody>();
                rb.velocity = Vector3.down * 100f;
                Destroy(patlamaObjesi, 1.0f);
            }

        }
        if (collision.gameObject.tag == "Balloon-Purple")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);          
            Canvas canvas = GetComponentInParent<Canvas>();

            for (int i = 0; i < patlamaPrefab.Length; i++)
            {
                GameObject patlamaObjesi = Instantiate(patlamaPrefab[3], transform.position, Quaternion.identity);
                patlamaObjesi.transform.localScale = canvas.transform.localScale + new Vector3(0.01f, 0.01f, 0.01f);
                patlamaObjesi.transform.SetParent(transform.parent);
                Rigidbody rb = patlamaObjesi.GetComponent<Rigidbody>();
                rb.velocity = Vector3.down * 100f;
                Destroy(patlamaObjesi, 1.0f);
            }

        }
        if (collision.gameObject.tag == "Balloon-Red")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Canvas canvas = GetComponentInParent<Canvas>();

            for (int i = 0; i < patlamaPrefab.Length; i++)
            {
                GameObject patlamaObjesi = Instantiate(patlamaPrefab[4], transform.position, Quaternion.identity);
                patlamaObjesi.transform.localScale = canvas.transform.localScale + new Vector3(0.01f, 0.01f, 0.01f);
                patlamaObjesi.transform.SetParent(transform.parent);
                Rigidbody rb = patlamaObjesi.GetComponent<Rigidbody>();
                rb.velocity = Vector3.down * 100f;
                Destroy(patlamaObjesi, 1.0f);
            }

        }
        if (collision.gameObject.tag == "Screen")
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}