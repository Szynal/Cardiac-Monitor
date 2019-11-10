using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI.Menu.Animations
{
    [RequireComponent(typeof(MainMenuUIMenager))]
    public class MainMenuUIAnimations : MonoBehaviour
    {
        [Header("Animated Panels")] [SerializeField]
        private Animation entryPanelAnim;

        [SerializeField] private Animation createPanelAnim;
        [SerializeField] private Animation continuePanelAnim;
        [SerializeField] private Animation optionsPanelAnim;
        [SerializeField] private Animation exitPanelAnim;

        [Header("Animation Speed")] [SerializeField]
        private static float animationSpeed = 1F;

        public MainMenuUIAnimations(Animation createPanelAnim, Animation entryPanelAnim, Animation continuePanelAnim,
            Animation optionsPanelAnim, Animation exitPanelAnim)
        {
            this.createPanelAnim = createPanelAnim;
            this.entryPanelAnim = entryPanelAnim;
            this.continuePanelAnim = continuePanelAnim;
            this.optionsPanelAnim = optionsPanelAnim;
            this.exitPanelAnim = exitPanelAnim;
        }

        private void Start()
        {
            InitAnimationStates();
        }

        private void InitAnimationStates()
        {
            if (entryPanelAnim == null || createPanelAnim == null || optionsPanelAnim == null || exitPanelAnim == null)
                Debug.LogError("Missing Animations");

            AnimationStateReverse(createPanelAnim);
            AnimationStateReverse(continuePanelAnim);
            AnimationStateReverse(optionsPanelAnim);
            AnimationStateReverse(exitPanelAnim);
            entryPanelAnim?.Play();
        }

        public void AnimatingPanels(Animation hidePanel, Animation unhidePanel)
        {
            if (unhidePanel != null)
            {
                AnimationStateReverse(unhidePanel);
                unhidePanel.Play();
            }

            if (hidePanel != null)
            {
                AnimationStateReverse(hidePanel);
                hidePanel.Play();
            }
        }

        private static void AnimationStateReverse(IEnumerable animations)
        {
            foreach (AnimationState state in animations)
            {
                state.time = 0F;
                state.speed *= -animationSpeed;
            }
        }

        public void NewGameUIAnimation()
        {
            AnimatingPanels(entryPanelAnim, createPanelAnim);
        }

        public void ContinueUIAnimation()
        {
            AnimatingPanels(entryPanelAnim, continuePanelAnim);
        }

        public void OptionsUIAnimation()
        {
            AnimatingPanels(entryPanelAnim, optionsPanelAnim);
        }

        public void ExitUIAnimation(bool hide)
        {
            if (hide)
            {
                AnimatingPanels(exitPanelAnim, null);
            }
            else
            {
                AnimatingPanels(null, exitPanelAnim);
            }
        }

        public void CreatePanel_ReturnUIAnimation()
        {
            AnimatingPanels(createPanelAnim, entryPanelAnim);
        }

        public void OptionsPanel_ReturnUIAnimation()
        {
            AnimatingPanels(optionsPanelAnim, entryPanelAnim);
        }

        public void ContinuePanel_ReturnUIAnimation()
        {
            AnimatingPanels(continuePanelAnim, entryPanelAnim);
        }
    }
}