using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestProbablity : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Chest Type Drop Rate")]
    public int WoodChestWeight;
    public int SilverChestWeight;
    public int GoldChestWeight;
    public int PlatinumChestWeight;
    public int ObsidianChestWeight;


    [Header("Chest Drop Rate")]
    [Header(" ")]
    public int woodCommon;
    public int woodUncommon;
    public int woodRare;
    public int woodEpic;
    public int woodLegendary;
    [Header(" ")]
    public int silverCommon;
    public int silverUncommon;
    public int silverRare;
    public int silverEpic;
    public int silverLegendary;
    [Header(" ")]
    public int goldCommon;
    public int goldUncommon;
    public int goldRare;
    public int goldEpic;
    public int goldLegendary;
    [Header(" ")]
    public int platCommon;
    public int platUncommon;
    public int platRare;
    public int platEpic;
    public int platLegendary;
    [Header(" ")]
    public int obsidianCommon;
    public int obsidianUncommon;
    public int obsidianRare;
    public int obsidianEpic;
    public int obsidianLegendary;

    string _chosenChest;
    string _chosenPrice;

    public List<string> chosenChest = new List<string>();
    public List<string> chosenWoodPrice;
    public List<string> chosenSilverPrice;
    public List<string> chosenGoldPrice;
    public List<string> chosenPlatPrice;
    public List<string> chosenObsidianPrice;
    void Start()
    {
        for (int  i = 0; i < WoodChestWeight; i++) chosenChest.Add("Wood Chest");
        for (int i = 0; i < SilverChestWeight; i++) chosenChest.Add("Silver Chest");
        for (int i = 0; i < GoldChestWeight; i++) chosenChest.Add("Gold Chest");
        for (int i = 0; i < PlatinumChestWeight; i++) chosenChest.Add("Platinum Chest");
        for (int i = 0; i < ObsidianChestWeight; i++) chosenChest.Add("Obsidian Chest");

        for (int i = 0; i < woodCommon; i++) chosenWoodPrice.Add("Common");
        for (int i = 0; i < woodUncommon; i++) chosenWoodPrice.Add("Uncommon");
        for (int i = 0; i < woodRare; i++) chosenWoodPrice.Add("Rare");
        for (int i = 0; i < woodEpic; i++) chosenWoodPrice.Add("Epic");
        for (int i = 0; i < woodLegendary; i++) chosenWoodPrice.Add("Legendary");

        for (int i = 0; i < silverCommon; i++) chosenSilverPrice.Add("Common");
        for (int i = 0; i < silverUncommon; i++) chosenSilverPrice.Add("Uncommon");
        for (int i = 0; i < silverRare; i++) chosenSilverPrice.Add("Rare");
        for (int i = 0; i < silverEpic; i++) chosenSilverPrice.Add("Epic");
        for (int i = 0; i < silverLegendary; i++) chosenSilverPrice.Add("Legendary");

        for (int i = 0; i < goldCommon; i++) chosenGoldPrice.Add("Common");
        for (int i = 0; i < goldUncommon; i++) chosenGoldPrice.Add("Uncommon");
        for (int i = 0; i < goldRare; i++) chosenGoldPrice.Add("Rare");
        for (int i = 0; i < goldEpic; i++) chosenGoldPrice.Add("Epic");
        for (int i = 0; i < goldLegendary; i++) chosenGoldPrice.Add("Legendary");

        for (int i = 0; i < platCommon; i++) chosenPlatPrice.Add("Common");
        for (int i = 0; i < platUncommon; i++) chosenPlatPrice.Add("Uncommon");
        for (int i = 0; i < platRare; i++) chosenPlatPrice.Add("Rare");
        for (int i = 0; i < platEpic; i++) chosenPlatPrice.Add("Epic");
        for (int i = 0; i < platLegendary; i++) chosenPlatPrice.Add("Legendary");

        for (int i = 0; i < obsidianCommon; i++) chosenObsidianPrice.Add("Common");
        for (int i = 0; i < obsidianUncommon; i++) chosenObsidianPrice.Add("Uncommon");
        for (int i = 0; i < obsidianRare; i++) chosenObsidianPrice.Add("Rare");
        for (int i = 0; i < obsidianEpic; i++) chosenObsidianPrice.Add("Epic");
        for (int i = 0; i < obsidianLegendary; i++) chosenObsidianPrice.Add("Legendary");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _chosenChest = chosenChest[UnityEngine.Random.Range(0, chosenChest.Count)];

            if (_chosenChest == "Wood Chest")
            {
                _chosenPrice = chosenWoodPrice[UnityEngine.Random.Range(0, chosenWoodPrice.Count)];
            }
            else if (_chosenChest == "Silver Chest")
            {
                _chosenPrice = chosenSilverPrice[UnityEngine.Random.Range(0, chosenSilverPrice.Count)];
            }
            else if (_chosenChest == "Gold Chest")
            {
                _chosenPrice = chosenGoldPrice[UnityEngine.Random.Range(0, chosenGoldPrice.Count)];
            }
            else if (_chosenChest == "Platinum Chest")
            {
                _chosenPrice = chosenPlatPrice[UnityEngine.Random.Range(0, chosenPlatPrice.Count)];
            }
            else if (_chosenChest == "Obsidian Chest")
            {
                _chosenPrice = chosenObsidianPrice[UnityEngine.Random.Range(0, chosenObsidianPrice.Count)];
            }

            Debug.Log("You got a " + _chosenChest + ". You get a " + _chosenPrice + " out of it!");
        }
       

    }


    public struct WAWA
    {
        public int sssss;

        public WAWA(int ss)
        {
            this.sssss = ss;
        }
    }
}
