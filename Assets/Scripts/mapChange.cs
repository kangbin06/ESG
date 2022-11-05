using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapChange : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Map3")
        {
            SceneManager.LoadScene("map3");
        }
        else if (other.tag == "Map2")
        {
            SceneManager.LoadScene("map2");
        }
        else if (other.tag == "Map1")
        {
            SceneManager.LoadScene("map1");
        }
        else if (other.tag == "Map4")
        {
            SceneManager.LoadScene("map4");
        }
    }
}
