using UnityEngine;
using UnityEngine.UI;

public class TestImageEventAlphaThreshold : MonoBehaviour
{
    private Image _image;
    private Button _button;

    [SerializeField]
    [Range(0f, 1f)]
    private float _eventAlphaThreshold;

    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _image.alphaHitTestMinimumThreshold = _eventAlphaThreshold;

        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        Debug.Log("Clicked" + gameObject.name);
    }
}
