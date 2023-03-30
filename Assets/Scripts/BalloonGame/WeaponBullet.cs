using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBullet : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float offset;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] public static Canvas canvas;
    [SerializeField] private float speed = 10;
    [SerializeField] private Transform wheel;
    [SerializeField] public GameObject bulletObject;
    [SerializeField] private List<GameObject> spawnObjects;
    [SerializeField] private Transform firePoint;
    public static bool updateEnabled;
    float minAngle = -20;
    float maxAngle = 50;
    float rotZ;
    int number;

    public GameObject cannon;
    Animation anim;

    public void Start()
    {
        CollisionControlBalloon.score = 0;
        CollisionControlBalloon2.score = 0;
        if (bulletObject != null)
        {
            // bulletObject varsa child nesnelerini sil
            foreach (Transform child in bulletObject.transform)
            {
                Destroy(child.gameObject);
            }
        }
        else
        {
            Debug.LogWarning("bulletObject is null.");
        }
    }
    public void Update()
    {
        if (updateEnabled == false)
        {
            if (!(Input.mousePosition.x >= wheel.position.x - 257 / 2 && Input.mousePosition.x <= wheel.position.x + 257 / 2 && Input.mousePosition.y >= wheel.position.y - 268 / 2 && Input.mousePosition.y <= wheel.position.y + 268 / 2))
            {
                cam.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z);
            }
            //cam.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Vector3 difference = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            rotZ = Mathf.Clamp(rotZ, minAngle, maxAngle);
            if (difference.sqrMagnitude > 0)
                difference = difference.normalized;
            if (difference.x < 0)
            {
                // Ters pozisyonda gidecek yer
                //difference = -difference;
                return;
            }
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
            if (Input.GetMouseButtonDown(0))
            {
                anim = cannon.GetComponent<Animation>();
                anim.Play("Cannon");
                GameObject newBullet = Instantiate(bulletPrefab, firePoint.position, transform.rotation);
                newBullet.transform.localScale = canvas.transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
                newBullet.name = "Bullet" + number;
                number++;
                newBullet.transform.SetParent(canvas.transform);
                newBullet.transform.SetParent(bulletObject.transform);
                spawnObjects.Add(newBullet);
                Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
                WeaponBullet.canvas = GetComponentInParent<Canvas>();
                rb.AddForce(difference * speed * WeaponBullet.canvas.scaleFactor);
            }
            
        }
    }
}