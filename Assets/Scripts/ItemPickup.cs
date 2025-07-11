using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItem item;
    private void OnMouseDown()

    {
        Inventory.Instance.AddItem(item);
        Destroy(gameObject);
    }

}
