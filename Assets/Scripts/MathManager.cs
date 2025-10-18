using TMPro;
using UnityEngine;

public class MathManager : MonoBehaviour
{
    public static MathManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI _numberText;
    [Range(-100, 100)] [SerializeField] private int _startingNumber = 0;
    [Range(-100, 100)] [SerializeField] private int _minNumber = -10;
    [Range(-100, 100)] [SerializeField] private int _maxNumber = 10;

    private int _currentNumber;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        _currentNumber = _startingNumber;
        _numberText.text = _currentNumber.ToString();
    }

    public void AddOrSubtract(int value)
    {
        _currentNumber += value;
        _numberText.text = _currentNumber.ToString();
    }

    private void OnValidate()
    {
        if (_minNumber > _maxNumber)
        {
            _minNumber = _maxNumber;
        }

        if (_maxNumber < _minNumber)
        {
            _maxNumber = _minNumber;
        }

        if (_startingNumber < _minNumber)
        {
            _startingNumber = _minNumber;
        }

        if (_startingNumber > _maxNumber)
        {
            _startingNumber = _maxNumber;
        }
    }
}
