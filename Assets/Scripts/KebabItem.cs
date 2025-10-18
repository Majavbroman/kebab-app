using UnityEngine;

[CreateAssetMenu(fileName = "KebabItem", menuName = "KebabItem", order = 0)]
public class KebabItem : ScriptableObject {
    public string Name;
    public float Price;
    public Sprite Image;
}
