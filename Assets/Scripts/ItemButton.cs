using UnityEngine;

public class ItemButton : MonoBehaviour
{
    [SerializeField] private KebabItem _item;

    public void OnButtonClick()
    {
        KebabManager.Instance.AddToCart(_item);
    }
}
