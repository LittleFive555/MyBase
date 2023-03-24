using UnityEngine;
using UnityEngine.EventSystems;

public class TestUIBehaviourFunctions : UIBehaviour
{
    /// <summary>
    /// This callback is called when the dimensions of an associated RectTransform change. It is always called before Awake, OnEnable, or Start. The call is also made to all child RectTransforms, regardless of whether their dimensions change (which depends on how they are anchored).
    /// </summary>
    protected override void OnRectTransformDimensionsChange()
    {
        Debug.Log("1.  OnRectTransformDimensionsChange");
    }

    protected override void OnBeforeTransformParentChanged()
    {
        Debug.Log("2.  OnBeforeTransformParentChanged");
    }

    protected override void OnTransformParentChanged()
    {
        Debug.Log("3.  OnTransformParentChanged");
    }

    protected override void OnDidApplyAnimationProperties()
    {
        Debug.Log("4.  OnDidApplyAnimationProperties");
    }

    protected override void OnCanvasGroupChanged()
    {
        Debug.Log("5.  OnCanvasGroupChanged");
    }

    /// <summary>
    /// Called when the state of the parent Canvas is changed.
    /// </summary>
    protected override void OnCanvasHierarchyChanged()
    {
        Debug.Log("6.  OnCanvasHierarchyChanged");
    }
}
