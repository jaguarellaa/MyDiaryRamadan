using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerBallon : MonoBehaviour
{
    [SerializeField] private List<Image> BalloonList;
    [SerializeField] public List<Image> BalloonListobject;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject BalloonObject;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] public int number;

    private void Start()
    {
        CancelInvoke("spawning");
        spawn();
    }
    public void spawn()
    {
        InvokeRepeating("spawning", 0f, 1.5f);
        if (BalloonListobject.Count == 0)
        {
            return;
        }
        foreach (Image balloon in BalloonListobject)
        {
            Destroy(balloon.gameObject);
        }
        BalloonListobject.Clear();
        number = 0;
    }
    public void spawning()
    {
        foreach (Transform spawnPoint in spawnPoint)
        {
            int randomIndex = Random.Range(0, BalloonList.Count);
            Image randomImage = BalloonList[randomIndex];
            Image clonedImage = Instantiate(randomImage, spawnPoint.position, spawnPoint.rotation);
            clonedImage.transform.localScale = canvas.transform.localScale;
            clonedImage.name = "Balloon" + number;
            number++;
            BalloonListobject.Add(clonedImage);
            clonedImage.transform.SetParent(canvas.transform);
            clonedImage.transform.SetParent(BalloonObject.transform);           
        }
    }
    public void CancelSpawn()
    {
        CancelInvoke("spawning");
    }
}