using UnityEngine;
using UnityEngine.UI;

public class ActivateMenuButton : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;

    public void ChangeMenu(){
        MenuManager.Instance.ChangeMenu(_menuPanel);
    }
}
