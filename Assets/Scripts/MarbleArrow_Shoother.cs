using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleArrow_Shoother : MonoBehaviour
{
    public GameObject marblePrefab;
    public LineRenderer lineRenderer;
    public float force = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject marble = Instantiate(marblePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rigidbody2D = marble.GetComponent<Rigidbody2D>();
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = (Vector2)(mousePos - transform.position);
        direction = direction.normalized;
        rigidbody2D.AddForce(direction * force, ForceMode2D.Impulse);

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, mousePos);
    }
}
