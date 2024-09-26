using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sch : MonoBehaviour
{
    public int x = 0;
    public Text Props;
    public GameObject Particle;
    public GameObject ToGreen;
    public GameObject Part1;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        x++;
        if (x<=111)
        {
            Props.text = x.ToString();
        }
        if (x == 111)
        {
            Particle.SetActive(true);
            ToGreen.GetComponent<Renderer>().material.color = Color.green;
            Part1.SetActive(true);
        }

    }
}
