using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Maze_GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] mazeList;
    public GameObject maze_FinishPanel;
    public float mazeMoveSpeed;
    private Rigidbody2D mazeRb;
    Vector3 mazeFirstPos;
    public GameObject mazePlayer;
    GameObject Wall;
    bool decpo;
    public AudioSource walk;
    public AudioSource city;
    public AudioSource joy;


    private void Awake()
    {
        decpo = true;
        mazeFirstPos = mazePlayer.transform.position;
    }
    private void Start()
    {
        city.Play();
        mazeRb = GetComponent<Rigidbody2D>();
        Wall = GameObject.FindGameObjectWithTag("MazeWalls");
    }
    void Update()
    {
        if(!decpo)
        {
            mazeRb.velocity = new Vector2(0f, 0f);
          
        }
      
    }
    public void MoveUp()
    {
        walk.Play();
       
        decpo = true;
        Vector2 direction = Vector2.up;
        Vector2 movement = direction * mazeMoveSpeed;
      
        mazeRb.velocity = movement;
    }
    public void MoveDown()
    {
        walk.Play();
        decpo = true;
        Vector2 direction = Vector2.down;
        Vector2 movement = direction * mazeMoveSpeed;
        mazeRb.velocity = movement;
       

    }
    public void MoveLeft()
    {
        walk.Play();
        decpo = true;
        Vector2 direction = Vector2.left;
        Vector2 movement = direction * mazeMoveSpeed;
        mazeRb.velocity = movement;

       
    }
    public void MoveRight()
    {

        walk.Play();
        decpo = true;
        Vector2 direction = Vector2.right;
        Vector2 movement = direction * mazeMoveSpeed;
        mazeRb.velocity = movement;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Maze_FinishPoint"))
        {

            joy.Play();
            maze_FinishPanel.SetActive(true);
            city.Stop();
        }
        if (collision.gameObject.CompareTag("DecisionPoint"))
        {
            decpo = false;
        }
    }
    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(4f);

        joy.Play();
        maze_FinishPanel.SetActive(true);

    }
    public void RestartMaze()
    {

        city.Play();
        mazePlayer.transform.position = mazeFirstPos;
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MazeWalls"))
        {
            Vector2 direction = collision.contacts[0].point - (Vector2)transform.position;
            float angle = Vector2.Angle(direction, Vector2.up);

            if ((angle < 45 && angle > -45) || (angle > 135 && angle < -135))
            {
                mazeRb.velocity = Vector2.zero;
            }
        }
    }
}
