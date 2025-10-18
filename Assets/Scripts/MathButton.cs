using UnityEngine;
using TMPro;

public class AddOrSubtractButton : MonoBehaviour
{
    [SerializeField] private int _value = 1;

    public void OnButtonClick(){
        MathManager.Instance.AddOrSubtract(_value);
    }
}
