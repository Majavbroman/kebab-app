using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject _currentMenu;
    [SerializeField] private GameObject _startMenu;

    public static MenuManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (_startMenu != null)
        {
            ChangeMenu(_startMenu);
        }
    }

    public void ChangeMenu(GameObject newMenu)
    {
        if (_currentMenu != null)
        {
            _currentMenu.SetActive(false);
        }

        newMenu.SetActive(true);
        _currentMenu = newMenu;
    }
}
