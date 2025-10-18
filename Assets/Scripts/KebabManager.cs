using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KebabManager : MonoBehaviour
{
    public static KebabManager Instance { get; private set; }

    [SerializeField] private List<KebabItem> _availableItems;
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private GameObject _itemGrid;

    private List<KebabItem> _cart;
    private float _totalPrice;
    [SerializeField] private float _money;
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private TextMeshProUGUI _totalPriceText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _cart = new List<KebabItem>();
        }
        else
        {
            Destroy(gameObject);
        }

        foreach (var item in _availableItems)
        {
            
        }
    }

    private void Start()
    {
        
    }

    public void AddToCart(KebabItem item)
    {
        _cart.Add(item);
        UpdateTotalPrice();
        Debug.Log($"Added item to cart. Total items: {_cart.Count}");
    }

    public void RemoveFromCart(KebabItem item)
    {
        if (_cart.Contains(item))
        {
            _cart.Remove(item);
            UpdateTotalPrice();
            Debug.Log($"Removed item from cart. Total items: {_cart.Count}");
        }
        else
        {
            Debug.LogWarning("Item not found in cart.");
        }
    }

    public void Buy(){
        if(_cart.Count == 0){
            Debug.Log("Cart is empty. Cannot proceed to buy.");
            return;
        }

        if(_totalPrice > _money){
            Debug.Log("Insufficient funds to complete the purchase.");
            return;
        }

        _money -= _totalPrice;
        _moneyText.text = $"Money: {_money}$";
        // Implement payment logic here
        Debug.Log($"Purchased {_cart.Count} items for a total of {_totalPrice}.");
        ClearCart();
    }

    public void ClearCart()
    {
        _cart.Clear();
        UpdateTotalPrice();
        Debug.Log("Cart cleared.");
    }

    public void UpdateTotalPrice(){
        _totalPrice = 0f;
        foreach (var item in _cart)
        {
            _totalPrice += item.Price;
            _totalPriceText.text = $"Total: {_totalPrice}$";
        }
        Debug.Log($"Total price updated: {_totalPrice}");
    }
}
