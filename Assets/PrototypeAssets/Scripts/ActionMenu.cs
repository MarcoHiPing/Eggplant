using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(RectTransform))]
public class ActionMenu : MonoBehaviour
{

    private bool menuShowing = false;
    private List<ActionMenuButton> children = new List<ActionMenuButton>();

    [SerializeField] private float circleRadius = 100f; // size of the inner circle
    [SerializeField] private float offset = 100f; // size of the inner circle

    private Vector2 pixelCenter;
    private int last_highlighted;

    void DoLayout()
    {
        var rectTransform = (this.transform as RectTransform);
        var center = rectTransform.anchoredPosition;
        pixelCenter = rectTransform.position;

        Vector2 dir = Vector2.up;

        var angle = 360f / children.Count;
        var rot = Quaternion.AngleAxis(angle, Vector3.forward);
        for (var i = 0; i < children.Count; ++i)
        {

            children[i].DoLayout(center, center + dir * (circleRadius + offset));

            dir = rot * (Vector3)dir;
        }
    }


    void OnValidate()
    {
        children = this.GetComponentsInChildren<ActionMenuButton>().ToList();
        DoLayout();
    }


    void Start()
    {
        children = this.GetComponentsInChildren<ActionMenuButton>().ToList();
        DoLayout();
        children.ForEach(f => f.gameObject.SetActive(false));
    }

    int PositionToChildIndex(Vector2 position)
    {
        var d = position - pixelCenter;
        if (d.sqrMagnitude < circleRadius * circleRadius) return -1;

        var angle = (360 - 90 + Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg) % 360;

        var range = 360f / children.Count; // degree range per child

        var index = (int)((range / 2 + angle) % 360 / range);

        Debug.Assert(index < children.Count);
        Debug.Assert(index > -1);

        return index;
    }

    void Update()
    {
        Cursor.visible = Input.GetKey(KeyCode.C);
        if (Input.GetKey(KeyCode.C))
            Cursor.lockState = CursorLockMode.None;
        else Cursor.lockState = CursorLockMode.Locked;

        var index = PositionToChildIndex(Input.mousePosition);

        if (Input.GetKeyUp(KeyCode.C))
        {
            children.ForEach(f => f.gameObject.SetActive(false));

            if (index != -1) children[index].Click();
        }
        if (!Input.GetKey(KeyCode.C)) return;


        // do the highlight stuff
        if (index != last_highlighted)
        {
            if (last_highlighted != -1) children[last_highlighted].Unhighlight();

            if (index != -1) children[index].Highlight();

            last_highlighted = index;
        }

        // do the show-menu stuff
        if (Input.GetKeyDown(KeyCode.C))
        {
            //menuShowing = true;
            children.ForEach(f => f.gameObject.SetActive(true));
            last_highlighted = -1;
        }


    }


}
