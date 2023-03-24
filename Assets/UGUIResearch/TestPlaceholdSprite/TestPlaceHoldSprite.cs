using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class TestPlaceHoldSprite : MonoBehaviour
{
    private Image _image;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("isUsingPlaceHolder   " + _image.sprite.isUsingPlaceholder);
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("sprite's texture is null   " + (_image.sprite.texture == null));
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("sprite is packed   " + _image.sprite.packed);
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("sprite's texture name   " + _image.sprite.texture.name);
        _text.text = stringBuilder.ToString();
    }
}
