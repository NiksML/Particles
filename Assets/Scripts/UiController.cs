using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;
    private float dist;
    public Text distText;
    public GameObject spheres;
    // Start is called before the first frame update
    void Start()
    {
        spheres.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(cube1.position, cube2.position);
        distText.text = "Distance between cubes " + dist.ToString();
        if(dist < 1 )
        {
            SceneManager.LoadScene(1);
        }
        else if(dist < 2 ) 
        {
            spheres.SetActive(true);
        }
        else
        {   
            spheres.SetActive(false);
        }
    }
}
