using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;
public class Inventory : MonoBehaviour
{

    public static Inventory Instance;

    public List<InventoryItem> items = new List<InventoryItem>();
    public Transform inventoryPanel;
    public GameObject inventorySlotPrefab;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Update is called once per frame
    public void UpdateUI()
    {
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        foreach (InventoryItem item in items)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);
            slot.GetComponentInChildren<Image>().sprite = item.icon;
        }
    }

    internal void AddItem(InventoryItem item)
    {
        throw new NotImplementedException();
    }
}
