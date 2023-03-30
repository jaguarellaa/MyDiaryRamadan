using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonControl : MonoBehaviour
{
    private float speed;
    private void Start()
    {
        speedchange();
    }
    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //transform.Translate(Vector3.up * speed * Time.deltaTime);
        //transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
    }
    void speedchange()
    {
        WeaponBullet.canvas = GetComponentInParent<Canvas>();
        speed = Random.Range(200f, 400f) * WeaponBullet.canvas.scaleFactor;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Screen")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}