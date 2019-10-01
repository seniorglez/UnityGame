using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coins;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        coins = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins: " + player.coins;
    }
}
