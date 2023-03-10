using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostersController : MonoBehaviour
{
    public GameObject player;
    private Animator playerAni;
    private Animator boosterAni;

    void Awake()
    {
        playerAni = player.GetComponent<Animator>();
        
        boosterAni = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        boosterAni.SetFloat("Horizontal", playerAni.GetFloat("Horizontal"));
        boosterAni.SetFloat("Speed X", playerAni.GetFloat("Speed X"));
    }
}
