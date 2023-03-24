using UnityEngine;
using UnityEngine.UI;

public class TestOverrideSprite : MonoBehaviour
{
    [SerializeField]
    private Sprite sprite1;
    [SerializeField]
    private Sprite sprite2;
    private Image i;

    public void Start()
    {
        i = GetComponent<Image>();

        i.sprite = sprite1;
    }

    // Called by a Button OnClick() with ExampleClass.Example1
    // Uses overrideSprite to make this change temporary
    public void Example1()
    {
        i.overrideSprite = sprite2;
    }

    // Called by a Button OnClick() with ExampleClass.Example2
    // Removes the overrideSprite which causes the original sprite to be used again.
    public void Example2()
    {
        i.overrideSprite = null;
    }
}