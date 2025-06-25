using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public Transform player;
    public void GoToItem(ItemData item )
    {
        player.position = item.goToPoint.position; 
    }
}
