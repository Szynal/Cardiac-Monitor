using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Image))]
    public class DragMe : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public bool DragOnSurfaces = true;

        private Dictionary<int, GameObject> draggingIcons = new Dictionary<int, GameObject>();
        private Dictionary<int, RectTransform> draggingPlanes = new Dictionary<int, RectTransform>();

        public void OnBeginDrag(PointerEventData eventData)
        {
            var canvas = FindInParents<Canvas>(gameObject);
            if (canvas == null)
            {
                return;
            }

            draggingIcons[eventData.pointerId] = new GameObject("icon");
            draggingIcons[eventData.pointerId].transform.SetParent(canvas.transform, false);
            draggingIcons[eventData.pointerId].transform.SetAsLastSibling();

            var image = draggingIcons[eventData.pointerId].AddComponent<Image>();
            var group = draggingIcons[eventData.pointerId].AddComponent<CanvasGroup>();
            group.blocksRaycasts = false;

            image.sprite = GetComponent<Image>().sprite;
            image.SetNativeSize();

            if (DragOnSurfaces)
            {
                draggingPlanes[eventData.pointerId] = transform as RectTransform;
            }
            else
            {
                draggingPlanes[eventData.pointerId] = canvas.transform as RectTransform;
            }

            SetDraggedPosition(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (draggingIcons[eventData.pointerId] != null)
            {
                SetDraggedPosition(eventData);
            }
        }

        private void SetDraggedPosition(PointerEventData eventData)
        {
            if (DragOnSurfaces && eventData.pointerEnter != null &&
                eventData.pointerEnter.transform as RectTransform != null)
            {
                draggingPlanes[eventData.pointerId] = eventData.pointerEnter.transform as RectTransform;
            }

            var rt = draggingIcons[eventData.pointerId].GetComponent<RectTransform>();

            if (!RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingPlanes[eventData.pointerId],
                eventData.position, eventData.pressEventCamera, out var globalMousePos))
            {
                return;
            }

            rt.position = globalMousePos;
            rt.rotation = draggingPlanes[eventData.pointerId].rotation;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (draggingIcons[eventData.pointerId] != null)
            {
                Destroy(draggingIcons[eventData.pointerId]);
            }

            draggingIcons[eventData.pointerId] = null;
        }

        public static T FindInParents<T>(GameObject go) where T : Component
        {
            if (go == null)
            {
                return null;
            }

            var comp = go.GetComponent<T>();

            if (comp != null)
            {
                return comp;
            }

            var t = go.transform.parent;
            while (t != null && comp == null)
            {
                comp = t.gameObject.GetComponent<T>();
                t = t.parent;
            }

            return comp;
        }
    }
}