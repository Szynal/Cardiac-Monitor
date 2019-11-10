using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class PanelManager : MonoBehaviour
    {
        public Animator InitiallyOpen;

        private int mOpenParameterId;
        private Animator open;
        private GameObject previouslySelected;

        private const string OpenTransitionName = "Open";
        private const string ClosedStateName = "Closed";

        public void OnEnable()
        {
            mOpenParameterId = Animator.StringToHash(OpenTransitionName);

            if (InitiallyOpen == null)
            {
                return;
            }


            OpenPanel(InitiallyOpen);
        }

        public void OpenPanel(Animator anim)
        {
            if (open == anim)
            {
                return;
            }

            anim.gameObject.SetActive(true);
            var newPreviouslySelected = EventSystem.current.currentSelectedGameObject;

            anim.transform.SetAsLastSibling();

            CloseCurrent();

            previouslySelected = newPreviouslySelected;

            open = anim;
            open.SetBool(mOpenParameterId, true);

            GameObject go = FindFirstEnabledSelectable(anim.gameObject);

            SetSelected(go);
        }

        private static GameObject FindFirstEnabledSelectable(GameObject gameObject)
        {
            var selectables = gameObject.GetComponentsInChildren<Selectable>(true);

            return (from selectable in selectables
                where selectable.IsActive() && selectable.IsInteractable()
                select selectable.gameObject).FirstOrDefault();
        }

        public void CloseCurrent()
        {
            if (open == null)
            {
                return;
            }


            open.SetBool(mOpenParameterId, false);
            SetSelected(previouslySelected);
            StartCoroutine(DisablePanelDeleyed(open));
            open = null;
        }

        private IEnumerator DisablePanelDeleyed(Animator anim)
        {
            bool closedStateReached = false;
            bool wantToClose = true;
            while (!closedStateReached && wantToClose)
            {
                if (!anim.IsInTransition(0))
                {
                    closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName(ClosedStateName);
                }

                wantToClose = !anim.GetBool(mOpenParameterId);

                yield return new WaitForEndOfFrame();
            }

            if (wantToClose)
            {
                anim.gameObject.SetActive(false);
            }
        }

        private void SetSelected(GameObject go)
        {
            EventSystem.current.SetSelectedGameObject(go);
        }
    }
}