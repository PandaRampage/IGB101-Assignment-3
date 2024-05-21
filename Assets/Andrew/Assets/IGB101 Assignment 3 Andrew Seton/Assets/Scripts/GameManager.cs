using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{

    public GameObject player;
        //pickip and level completion logic
        public int currentPickup = 0;
        public int maxPickups = 5;
        public bool levelComplete = false;

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update(){
        levelCompleteCheck();
        UpdateGUI();
    }

    public Text pickupText;

    private void UpdateGUI(){
        pickupText.text = "pickups: " + currentPickup + "/" + maxPickups;
    }

    private void levelCompleteCheck(){

    if (currentPickup >= maxPickups)
        levelComplete = true;
        else
        levelComplete = false;


    }
}
