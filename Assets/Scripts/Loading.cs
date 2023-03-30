using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{   

    public 
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(loadNext), 1f);
    }

    // Update is called once per frame
    public void loadNext()
    {
        SceneManager.LoadScene(1);
    }
}
