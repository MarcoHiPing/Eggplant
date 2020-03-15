using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ActionMenuButton : MonoBehaviour
{

    [SerializeField] private Text text;
    [SerializeField] private Image image;

    public UnityEvent OnClickEvent; // you can fill the on-click actions in the inspector

    public void OnValidate()
    {
        text = text ?? GetComponentInChildren<Text>();
        image = image ?? GetComponentInChildren<Image>();

        if (text || image == null) this.enabled = false;
    }

    public void DoLayout(Vector2 center, Vector2 position)
    {
        var dir = position - center;

        image.rectTransform.anchoredPosition = position;

        dir.Normalize();
        dir.x *= image.rectTransform.rect.width / 2 + text.preferredWidth;
        dir.y *= image.rectTransform.rect.height / 2 + text.preferredHeight;
        text.rectTransform.anchoredPosition = position + dir;

    }

    public void Click()
    {
        OnClickEvent.Invoke();
    }

    public void Highlight()
    {
        image.color = Color.red;
    }

    public void Unhighlight()
    {
        image.color = Color.white;

    }
}

